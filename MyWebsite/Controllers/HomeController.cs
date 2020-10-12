using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View(); // returns Views/Home/Index.cshtml
        }

        [Route("About")]
        public IActionResult About()
        {
            
            return View(); // returns Views/Home/About.cshtml
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View(); //returns Views/Home/Contract.cshtml
        }
    }
}
