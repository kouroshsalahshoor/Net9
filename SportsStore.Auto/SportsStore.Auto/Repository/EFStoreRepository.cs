using SportsStore.Auto.Client.Models;
using SportsStore.Auto.Data;
using SportsStore.Auto.Repository.IRepository;

namespace SportsStore.Auto.Repository
{
    public class EFStoreRepository : IStoreRepository
    {
        private ApplicationDbContext context;
        public EFStoreRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
        public void CreateProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
        }
        public void DeleteProduct(Product p)
        {
            context.Remove(p);
            context.SaveChanges();
        }
        public void SaveProduct(Product p)
        {
            context.SaveChanges();
        }
    }
}
