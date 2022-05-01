using Microsoft.AspNetCore.Mvc;

namespace Sample.Api.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
