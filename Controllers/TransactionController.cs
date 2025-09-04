using Microsoft.AspNetCore.Mvc;

namespace BudgetApp.Controllers;

public class TransactionController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}