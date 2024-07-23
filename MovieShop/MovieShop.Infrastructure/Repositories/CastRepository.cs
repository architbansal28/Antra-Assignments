using Microsoft.EntityFrameworkCore;
using MovieShop.Core.Entities;
using MovieShop.Core.Interfaces.Repositories;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repositories;

public class CastRepository : BaseRepository<Cast>, ICastRepository
{
    private readonly MovieShopDbContext _dbContext;

    public CastRepository(MovieShopDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public override Cast GetById(int id)
    {
        return _dbContext.Casts.Include(c => c.MovieCasts)
            .ThenInclude(mc => mc.Movie)
            .FirstOrDefault(c => c.Id == id);
    }
}