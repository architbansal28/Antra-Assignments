using MovieShop.Core.Entities;

namespace MovieShop.Core.Interfaces.Repositories;

public interface IMovieRepository : IRepository<Movie>
{
    IEnumerable<Movie> GetHighestGrossingMovies();
    Movie GetMovieById(int id);
}