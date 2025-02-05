using SportsStore.Auto.Client.Models;

namespace SportsStore.Auto.Repository.IRepository
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
