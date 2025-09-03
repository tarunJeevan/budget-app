using System.ComponentModel.DataAnnotations;

namespace BudgetApp.Models;

public class Transaction
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; } // Foreign key to owning User entity
    
    public Guid CategoryId { get; set; } // Foreign key to associated TransactionCategory entity
    
    [Required(ErrorMessage = "Transaction frequency must be set.")]
    public TransactionFrequency Frequency { get; set; }
    
    public DateTime Date { get; set; } = DateTime.UtcNow;
}