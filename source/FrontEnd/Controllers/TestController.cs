using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class TestController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
