using Microsoft.AspNetCore.Mvc;
using Silicon_WebApp.ViewModels;

namespace Silicon_WebApp.Controllers;

public class DefaultController : Controller
{
    public IActionResult Home(HomeIndexViewModel viewModel)
    { 
            return View(viewModel);
    }

}
