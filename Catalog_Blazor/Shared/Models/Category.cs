using System.ComponentModel.DataAnnotations;

namespace Catalog_Blazor.Shared.Models;

public class Category
{
    public int CategoryId { get; set; }
    [MaxLength(100)]
    public string? Name { get; set; }
    [MaxLength(200)]
    public string? Description { get; set; }

    public ICollection<Product>? Products { get; set; }

}
