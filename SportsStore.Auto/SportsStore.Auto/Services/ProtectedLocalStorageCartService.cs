using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using SportsStore.Auto.Client.Models;

namespace SportsStore.Auto.Client.Services
{
    public class ProtectedLocalStorageCartService : CartService
    {
        private readonly ProtectedLocalStorage _protectedLocalStorage;

        public ProtectedLocalStorageCartService(ProtectedLocalStorage protectedLocalStorage)
        {
            _protectedLocalStorage = protectedLocalStorage;
        }

        public async Task Load()
        {
            var result = await _protectedLocalStorage.GetAsync<List<CartLine>>("cart");
            Lines = result.Success ? result.Value! : new List<CartLine>();
        }

        public override async Task AddItem(Product product, int quantity)
        {
            await base.AddItem(product, quantity);
            await _protectedLocalStorage.SetAsync("cart", Lines);
        }
        public override async Task RemoveLine(Product product)
        {
            await base.RemoveLine(product);
            await _protectedLocalStorage.SetAsync("cart", Lines);
        }

        public override async Task Clear()
        {
            await base.Clear();
            await _protectedLocalStorage.DeleteAsync("cart");
        }
    }
}
