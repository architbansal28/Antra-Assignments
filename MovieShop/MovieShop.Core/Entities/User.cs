using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShop.Core.Entities;

public class User
{
    public int Id { get; set; }
    [Required]
    [MaxLength(128)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(128)]
    public string LastName { get; set; }
    [Required]
    [MaxLength(256)]
    public string Email { get; set; }
    [Required]
    [MaxLength(1024)]
    public string HashedPassword { get; set; }
    [Required]
    [MaxLength(1024)]
    public string Salt { get; set; }
    [Column(TypeName = "datetime2")]
    public DateTime? DateOfBirth { get; set; }
    [MaxLength(16)]
    public string? PhoneNumber { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public bool? IsLocked { get; set; }
    public ICollection<Favorite> Favorites { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<Purchase> Purchases { get; set; }
    public ICollection<UserRole> UserRoles { get; set; }
}