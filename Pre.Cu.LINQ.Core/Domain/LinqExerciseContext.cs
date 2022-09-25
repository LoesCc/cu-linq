using Microsoft.EntityFrameworkCore;

namespace Pre.Cu.LINQ.Core.Domain;

public class LinqExerciseContext : DbContext
{
    public LinqExerciseContext(DbContextOptions<LinqExerciseContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Pokemon> Pokemon { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderLine>().HasKey(ol => new { ol.OrderId, ol.ProductId });
        base.OnModelCreating(modelBuilder);
    }
}