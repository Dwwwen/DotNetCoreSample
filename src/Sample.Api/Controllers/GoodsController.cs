using Microsoft.AspNetCore.Mvc;

namespace Sample.Api.Controllers;

public class GoodsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
