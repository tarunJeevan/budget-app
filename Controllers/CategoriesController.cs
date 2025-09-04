using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.Controllers;

public class CategoriesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}