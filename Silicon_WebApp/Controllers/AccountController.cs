using Microsoft.AspNetCore.Mvc;

namespace Silicon_WebApp.Controllers;

public class AccountController : Controller
{
    public IActionResult Details()
    {
        return View();
    }
}
