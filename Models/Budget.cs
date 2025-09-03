using System.ComponentModel.DataAnnotations;

namespace BudgetApp.Models;

public class Budget
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; } // Foreign key to owning User entity
    
    [Required(ErrorMessage = "Budget name is required.")]
    [StringLength(50, ErrorMessage = "Budget name cannot exceed 50 characters.")]
    public string Name { get; set; } = null!;
    
    [Required(ErrorMessage = "Total budget amount must be set.")]
    [Range(0, Double.MaxValue)]
    public decimal BudgetedAmount { get; set; }
    
    [Required(ErrorMessage = "Start date is required.")]
    public DateTime StartDate { get; set; }
    
    [Required(ErrorMessage = "End date is required.")]
    public DateTime EndDate { get; set; }
}