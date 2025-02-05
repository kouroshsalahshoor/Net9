using SportsStore.Auto.Client.Models;

namespace SportsStore.Auto.Repository.IRepository
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
