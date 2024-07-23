using System.ComponentModel.DataAnnotations.Schema;

namespace MovieShop.Core.Entities;

public class Purchase
{
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    [Column(TypeName = "datetime2")]
    public DateTime PurchaseDateTime { get; set; }
    [Column(TypeName = "uniqueidentifier")]
    public Guid PurchaseNumber { get; set; }
    [Column(TypeName = "decimal(5,2)")]
    public decimal TotalPrice { get; set; }
}