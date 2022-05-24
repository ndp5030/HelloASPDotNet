using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNet.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/hello")]
        public IActionResult Welcome(string name = "World")
        {
            ViewBag.person = name;
            return View();
        }
    }
}
