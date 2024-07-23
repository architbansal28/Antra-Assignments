using MovieShop.Core.Entities;
using MovieShop.Core.Interfaces.Repositories;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repositories;

public class PurchaseRepository : BaseRepository<Purchase>, IPurchaseRepository
{
    public PurchaseRepository(MovieShopDbContext dbContext) : base(dbContext)
    {
    }
}