using System.ComponentModel.DataAnnotations;

namespace Family_migrations.Models;

public class Category_transaction
{
    [Key]
    public int Id_Category { get; set; }

    public string? Name_category { get; set; }
}