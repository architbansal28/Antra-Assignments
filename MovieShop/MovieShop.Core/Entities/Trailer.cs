using System.ComponentModel.DataAnnotations;

namespace MovieShop.Core.Entities;

public class Trailer
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    [Required]
    [MaxLength(2084)]
    public string Name { get; set; }
    [Required]
    [MaxLength(2084)]
    public string TrailerUrl { get; set; }
    public Movie Movie { get; set; }
}