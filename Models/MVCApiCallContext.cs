using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVCApiCall.Models
{
  public class MVCApiCallContext : IdentityDbContext<ApplicationUser>
  {
    // public virtual DbSet<Category> Categories { get; set; }
    // public DbSet<Item> Items { get; set; }
    // public DbSet<CategoryItem> CategoryItem { get; set; }

    public MVCApiCallContext(DbContextOptions options) : base(options) { }
  }
}