using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace IISRegression.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            var str = "Hello " + name;
            ViewData["Message"] = str;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
