using Catalog_Blazor.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog_Blazor.Server.Context;

public class AppDbContext : DbContext
{
    // Contructor
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}
