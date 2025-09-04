using System.ComponentModel.DataAnnotations;

namespace BudgetApp.Models;

public class Budget
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; } // Foreign key to owning User entity
    
    [Required(ErrorMessage = "Budget name is required.")]
    [StringLength(50, ErrorMessage = "Budget name cannot exceed 50 characters.")]
    public string Name { get; set; } = null!;
    
    [Required(ErrorMessage = "Budget allocation type must be set.")]
    public AllocationType AllocationType { get; set; }
    
    // Optional budget cap; income and expense total cannot exceed this amount if set
    [Required(ErrorMessage = "Budget amount must be set")]
    [Range(1, double.MaxValue)]
    public decimal BudgetedAmount { get; set; }
    
    // Current amount spent in this budget period
    [Range(0, double.MaxValue)]
    public decimal AmountSpent { get; set; } = 0;

    [Required(ErrorMessage = "Start date is required.")]
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    
    [Required(ErrorMessage = "End date is required.")]
    public DateTime EndDate { get; set; }
    
    public decimal GetAmountSpent() =>
        AllocationType == AllocationType.Percentage
            ? (AmountSpent / BudgetedAmount) * 100
            : AmountSpent;
}