using SportsStore.Auto.Client.Models;

namespace SportsStore.Auto.Client.Services
{
    public class CartService
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual async Task AddItem(Product product, int quantity)
        {
            CartLine? line = Lines.Where(p => p.Product.Id == product.Id).FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual async Task RemoveLine(Product product) => Lines.RemoveAll(l => l.Product.Id == product.Id);
        public decimal ComputeTotalValue() => Lines.Sum(e => e.Product.Price * e.Quantity);
        public virtual async Task Clear() => Lines.Clear();
        public virtual async Task Load() { }
    }
}
