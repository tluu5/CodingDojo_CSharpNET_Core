using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sessionDemo.Models;
using Microsoft.AspNetCore.Http;

namespace sessionDemo.Controllers
{
    public class HomeController : Controller
    {

        public List<String> Names = new List<String>() {"qq","ww","ee","rr","tt","yy","uu","ii","oo","pp","aa","ss","dd","ff","gg","hh","jj","kk","ll","zz","xx","cc","vv","bb","nn","mm"};
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // HttpContext.Session.SetString("name", "Brian");
            // string myName = HttpContext.Session.GetString("name");
            // Console.WriteLine(myName);
            // ViewBag.SessionName = myName;
            // if(myName == null){
            //     Console.WriteLine("Nothing in session");
            // } else {
            //     Console.WriteLine(myName);
            // }
            if(HttpContext.Session.GetString("inSession") == null)
            {
                Console.WriteLine("There was nothing in session, creating a new one");
                HttpContext.Session.SetString("inSession", "Working");
                HttpContext.Session.SetString("CharName", Names[1]);
                HttpContext.Session.SetInt32("CharLevel", 10);
                HttpContext.Session.SetInt32("CharStr", 7);
                HttpContext.Session.SetInt32("CharInt", 12);
                HttpContext.Session.SetInt32("CharDex", 8);
                HttpContext.Session.SetInt32("CharImg", 1);
            } else {
                Console.WriteLine("There was already a session.");
            }
            int? charImgNum = HttpContext.Session.GetInt32("CharImg");
            ViewBag.CharImg = Url.Content($"~/images/{charImgNum}.jpeg");
            ViewBag.CharName = HttpContext.Session.GetString("CharName");
            ViewBag.CharLvl = HttpContext.Session.GetInt32("CharLevel");
            ViewBag.CharStr = HttpContext.Session.GetInt32("CharStr");
            ViewBag.CharInt = HttpContext.Session.GetInt32("CharInt");
            ViewBag.CharDex = HttpContext.Session.GetInt32("CharDex");
            return View("Index");
        }

        [HttpGet("generate")]
        public IActionResult Generate()
        {
            Random rand = new Random();
            HttpContext.Session.SetString("CharName", Names[rand.Next(0,Names.Count)]);
            HttpContext.Session.SetInt32("CharLevel", rand.Next(1,11));
            HttpContext.Session.SetInt32("CharStr", rand.Next(1,15));
            HttpContext.Session.SetInt32("CharInt", rand.Next(1,15));
            HttpContext.Session.SetInt32("CharDex", rand.Next(1,12));
            HttpContext.Session.SetInt32("CharImg", rand.Next(1,5));
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
