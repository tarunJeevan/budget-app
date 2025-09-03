using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BudgetApp.Models;

public class User : IdentityUser<Guid>
{
    [Required(ErrorMessage = "Username is required."), MaxLength(50)]
    public string Username { get; set; }
    
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string Email { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    // TODO: Add password hash
}