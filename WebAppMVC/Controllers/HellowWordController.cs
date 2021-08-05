using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace WebAppMVC.Controllers
{
    public class HelloWorldController : Controller
    {

        // 
        // GET: /HelloWorld/

        /*
        public string Index()
        {
            return "This is my default action...";
        }
        
        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numtimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, You have hit this page {numtimes} times");
        }

        public string Welcome1(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
        */

        public IActionResult Index(string name = "Default Name", int numTimes = 1)
        {
            ViewData["Message"] = "Hello from Dick to: " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
        
    }
}
