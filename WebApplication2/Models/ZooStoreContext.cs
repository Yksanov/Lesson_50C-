using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models;

public class ZooStoreContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }
    public ZooStoreContext(DbContextOptions<ZooStoreContext> options) : base(options) { }
}