using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AppMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {

          //  return "This is my default action...";
           return View();
        }

        public IActionResult Welcome(string name, int numTimes = 6)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
