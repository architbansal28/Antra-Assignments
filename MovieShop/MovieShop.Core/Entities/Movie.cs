using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShop.Core.Entities;

public class Movie
{
    public int Id { get; set; }
    [Required]
    [MaxLength(256)]
    public string? Title { get; set; }
    public string? Overview { get; set; }
    [MaxLength(512)]
    public string? Tagline { get; set; }
    [MaxLength(2084)]
    public string? ImdbUrl { get; set; }
    [MaxLength(2084)]
    public string? TmdbUrl { get; set; }
    [MaxLength(2084)]
    public string? PosterUrl { get; set; }
    [MaxLength(2084)]
    public string? BackdropUrl { get; set; }
    [MaxLength(64)]
    public string? OriginalLanguage { get; set; }
    [Column(TypeName = "datetime2")]
    public DateTime? ReleaseDate { get; set; }
    public int? RunTime { get; set; }
    [Column(TypeName = "decimal(5,2)")]
    public decimal? Price { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal? Budget { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal? Revenue { get; set; }
    public string? CreatedBy { get; set; }
    [Column(TypeName = "datetime2")]
    public DateTime? CreatedDate { get; set; }
    public string? UpdatedBy { get; set; }
    [Column(TypeName = "datetime2")]
    public DateTime? UpdatedDate { get; set; }
    public ICollection<MovieGenre> MovieGenres { get; set; }
    public ICollection<Trailer> Trailers { get; set; }
    public ICollection<MovieCast> MovieCasts { get; set; }
    public ICollection<Favorite> Favorites { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<Purchase> Purchases { get; set; }
}