using Microsoft.EntityFrameworkCore;
using NetNova.Models;

namespace NetNova.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
  }
}
