using SportsStore.Auto.Client.Models;

namespace SportsStore.Auto.Client.Services
{
    public class CartLine
    {
        public int Id { get; set; }
        public Product Product { get; set; } = new();
        public int Quantity { get; set; }
    }
}
