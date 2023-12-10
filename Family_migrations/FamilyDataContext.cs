using Microsoft.EntityFrameworkCore;
using Family_migrations.Models;

namespace Family_migrations;

public class FamilyDataContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    public DbSet<Transaction> Transactions { get; set; } = null!;

    public DbSet<Category_transaction> Category { get; set; } = null!;

    public DbSet<Type_transaction> Type { get; set; } = null!;
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Family;Username=postgres;Password=8938");
    }
}