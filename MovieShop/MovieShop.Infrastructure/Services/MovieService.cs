using MovieShop.Core.Entities;
using MovieShop.Core.Interfaces.Repositories;
using MovieShop.Core.Interfaces.Services;
using MovieShop.Core.Models.Request;
using MovieShop.Core.Models.Response;

namespace MovieShop.Infrastructure.Services;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public MovieResponseModel GetMovieDetails(int id)
    {
        var movie = _movieRepository.GetMovieById(id);
        if (movie != null)
        {
            return new MovieResponseModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                Overview = movie.Overview,
                Tagline = movie.Tagline,
                Budget = movie.Budget,
                Revenue = movie.Revenue,
                ImdbUrl = movie.ImdbUrl,
                TmdbUrl = movie.TmdbUrl,
                PosterUrl = movie.PosterUrl,
                BackdropUrl = movie.BackdropUrl,
                OriginalLanguage = movie.OriginalLanguage,
                ReleaseDate = movie.ReleaseDate,
                RunTime = movie.RunTime,
                Price = movie.Price
            };
        }
        return null;
    }

    public int InsertMovie(MovieRequestModel movie)
    {
        Movie movieEntity = new()
        {
            Title = movie.Title,
            Overview = movie.Overview,
            Tagline = movie.Tagline,
            Budget = movie.Budget,
            Revenue = movie.Revenue,
            ImdbUrl = movie.ImdbUrl,
            TmdbUrl = movie.TmdbUrl,
            PosterUrl = movie.PosterUrl,
            BackdropUrl = movie.BackdropUrl,
            OriginalLanguage = movie.OriginalLanguage,
            ReleaseDate = movie.ReleaseDate,
            RunTime = movie.RunTime,
            Price = movie.Price
        };
        return _movieRepository.Insert(movieEntity);
    }

    public int UpdateMovie(MovieRequestModel movie, int id)
    {
        Movie movieEntity = new()
        {
            Id = id,
            Title = movie.Title,
            Overview = movie.Overview,
            Tagline = movie.Tagline,
            Budget = movie.Budget,
            Revenue = movie.Revenue,
            ImdbUrl = movie.ImdbUrl,
            TmdbUrl = movie.TmdbUrl,
            PosterUrl = movie.PosterUrl,
            BackdropUrl = movie.BackdropUrl,
            OriginalLanguage = movie.OriginalLanguage,
            ReleaseDate = movie.ReleaseDate,
            RunTime = movie.RunTime,
            Price = movie.Price
        }; 
        return _movieRepository.Update(movieEntity);
    }

    public int DeleteMovie(int id)
    {
        return _movieRepository.Delete(id);
    }

    public IEnumerable<MovieResponseModel> GetAllMovies()
    {
        var movies = _movieRepository.GetAll();
        List<MovieResponseModel> movieResponseModels = new List<MovieResponseModel>();
        foreach (var movie in movies)
        {
            movieResponseModels.Add(new MovieResponseModel
            {
                Id = movie.Id,
                Title = movie.Title,
                Overview = movie.Overview,
                Tagline = movie.Tagline,
                Budget = movie.Budget,
                Revenue = movie.Revenue,
                ImdbUrl = movie.ImdbUrl,
                TmdbUrl = movie.TmdbUrl,
                PosterUrl = movie.PosterUrl,
                BackdropUrl = movie.BackdropUrl,
                OriginalLanguage = movie.OriginalLanguage,
                ReleaseDate = movie.ReleaseDate,
                RunTime = movie.RunTime,
                Price = movie.Price
            });
        }
        return movieResponseModels;
    }

    public MovieResponseModel GetMovieById(int id)
    {
        var movie = _movieRepository.GetById(id);
        if (movie != null)
        {
            return new MovieResponseModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                Overview = movie.Overview,
                Tagline = movie.Tagline,
                Budget = movie.Budget,
                Revenue = movie.Revenue,
                ImdbUrl = movie.ImdbUrl,
                TmdbUrl = movie.TmdbUrl,
                PosterUrl = movie.PosterUrl,
                BackdropUrl = movie.BackdropUrl,
                OriginalLanguage = movie.OriginalLanguage,
                ReleaseDate = movie.ReleaseDate,
                RunTime = movie.RunTime,
                Price = movie.Price
            };
        }
        return null; 
    }

    public IEnumerable<MovieResponseModel> GetHighestGrossingMovies()
    {
        var movies = _movieRepository.GetHighestGrossingMovies();
        return movies.Select(movie => new MovieResponseModel
        {
            Id = movie.Id,
            Title = movie.Title,
            Overview = movie.Overview,
            Tagline = movie.Tagline,
            Budget = movie.Budget,
            Revenue = movie.Revenue,
            ImdbUrl = movie.ImdbUrl,
            TmdbUrl = movie.TmdbUrl,
            PosterUrl = movie.PosterUrl,
            BackdropUrl = movie.BackdropUrl,
            OriginalLanguage = movie.OriginalLanguage,
            ReleaseDate = movie.ReleaseDate,
            RunTime = movie.RunTime,
            Price = movie.Price
        });
    }
}