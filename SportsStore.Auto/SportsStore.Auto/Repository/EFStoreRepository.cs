using SportsStore.Auto.Client.Models;
using SportsStore.Auto.Data;

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
    }
}
