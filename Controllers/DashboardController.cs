using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.Controllers;

public class DashboardController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}