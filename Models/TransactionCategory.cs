using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BudgetApp.Models;

public class TransactionCategory
{
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Category name is required.")]
    [StringLength(15, ErrorMessage = "Category name cannot exceed 15 characters.")]
    public string Name { get; set; } = null!;
    
    [StringLength(50, ErrorMessage = "Category description cannot exceed 50 characters.")]
    public string? Description { get; set; }
    
    [Required(ErrorMessage = "Transaction type is required.")]
    [DefaultValue(TransactionType.Income)]
    public TransactionType Type { get; set; }
}