using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Catalog_Blazor.Shared.Models;

public class Product
{
    public int ProductId { get; set; }
    [MaxLength(100)]
    public string? Name { get; set; }
    [MaxLength(200)]
    public string? Description { get; set; }
    [Column(TypeName = "decimal(12,2")]
    public decimal? Price { get; set; }
    [MaxLength(250)]
    public string? ImageUrl { get; set; }

    // indicate the relationship 
    public int CategoryId { get; set; }
    // navigation prop
    public virtual Category? Category { get; set; }
}
