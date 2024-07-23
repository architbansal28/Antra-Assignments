using System.ComponentModel.DataAnnotations;

namespace MovieShop.Core.Entities;

public class Genre
{
    public int Id { get; set; }
    [Required]
    [MaxLength(24)]
    public string Name { get; set; }
    public ICollection<MovieGenre> MovieGenres { get; set; }
}