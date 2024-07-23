using System.ComponentModel.DataAnnotations;

namespace MovieShop.Core.Entities;

public class MovieCast
{
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
    public int CastId { get; set; }
    public Cast Cast { get; set; }
    [MaxLength(450)]
    public string Character { get; set; }
}