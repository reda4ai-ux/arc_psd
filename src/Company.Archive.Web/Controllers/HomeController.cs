using Microsoft.AspNetCore.Mvc;

namespace Company.Archive.Web.Controllers;

public sealed class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index() => View();
}
