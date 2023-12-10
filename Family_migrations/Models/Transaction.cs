using System.ComponentModel.DataAnnotations;

namespace Family_migrations.Models;

public class Transaction
{
    [Key]
    public int Id_transaction { get; set; }
    
    public string? Name_transaction { get; set; }
    
    public DateTime Date { get; set; }
    
    public int sum { get; set; }
    
    public List<Type_transaction> Type_transaction { get; set; }
    
    public List<Category_transaction> CategoryTransactions { get; set; }  
}