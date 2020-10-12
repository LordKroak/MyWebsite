using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Index(string id)
        {
            if (id == "Page2")
            {
                return View("Page2"); //Views/Tutorial/Page2.cshtml
            }
            if (id == "Page3")
            {
                return View("Page3"); //Views/Tutorial/Page3.cshtml
            }
            return View("Page1"); //Views/Tutorial/Page1.cshtml
            //if anything other then 2 or 3 is put in, defaults to Page1
        }
    }
}
