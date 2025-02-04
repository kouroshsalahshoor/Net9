using SportsStore.Auto.Client.Models;

namespace SportsStore.Auto.Repository
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
