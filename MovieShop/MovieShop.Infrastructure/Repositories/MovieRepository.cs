using Microsoft.EntityFrameworkCore;
using MovieShop.Core.Entities;
using MovieShop.Core.Interfaces.Repositories;
using MovieShop.Infrastructure.Data;

namespace MovieShop.Infrastructure.Repositories;

public class MovieRepository : BaseRepository<Movie>, IMovieRepository
{
    private readonly MovieShopDbContext _dbContext;

    public MovieRepository(MovieShopDbContext dbContext): base(dbContext)
    {
    }

    public IEnumerable<Movie> GetHighestGrossingMovies()
    {
        return _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(10).ToList();
    }

    public Movie GetMovieById(int id)
    {
        return _dbContext.Movies.Include(m => m.MovieGenres)
            .ThenInclude(mg => mg.Genre)
            .Include(m => m.Trailers)
            .Include(m => m.MovieCasts)
            .ThenInclude(mc => mc.Cast)
            .FirstOrDefault(m => m.Id == id);
    }
}