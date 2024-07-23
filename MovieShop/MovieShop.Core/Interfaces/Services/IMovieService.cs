using MovieShop.Core.Models.Request;
using MovieShop.Core.Models.Response;

namespace MovieShop.Core.Interfaces.Services;

public interface IMovieService
{
    int InsertMovie(MovieRequestModel movie);
    int UpdateMovie(MovieRequestModel movie, int id);
    int DeleteMovie(int id);
    IEnumerable<MovieResponseModel> GetAllMovies(); 
    MovieResponseModel GetMovieById(int id);
    IEnumerable<MovieResponseModel> GetHighestGrossingMovies();
    MovieResponseModel GetMovieDetails(int id); 
}