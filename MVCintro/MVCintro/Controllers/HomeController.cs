using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCintro.Models;

namespace MVCintro.Controllers {
   // [Route("Sales")]
    public class HomeController : Controller {

       public IActionResult ProductofTheDay()
        {
            return this.View();
        }

        
       // [Route("Greeting")]
        public string SayHello() {
            return "Hello World!";
        }
        public IActionResult Index() {
            return View("Index");
        }
       // [Route ("/Privacy")]
        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
