using Microsoft.AspNetCore.Mvc;

namespace PR_1.Controllers;

public class CategoryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}