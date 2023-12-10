using System.ComponentModel.DataAnnotations;

namespace Family_migrations.Models;

public class Type_transaction
{
    [Key]
    public int Id_Type { get; set; }
    
    public string? Name_type { get; set; } 
}