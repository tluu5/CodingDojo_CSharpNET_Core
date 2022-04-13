using System;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebPage.Controllers
{
    public class FirstController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            string[] myArray = new string[] {"One", "Two", "Three"};
            ViewBag.StringArray = myArray;
            return View("Index");
        }
        [HttpGet]
        [Route("second")]
        public ViewResult Second()
        {
            ViewBag.myVariable = "This is coming from my viewbag";
            return View("Second");
        }
        [HttpGet("redirect")]
        public RedirectToActionResult Redirect()
        {
            return RedirectToAction("Second");
        }
        [HttpGet("form")]
        public ViewResult Form()
        {
            return View();
        }
        [HttpPost("postForm")]
        public IActionResult postForm(string Name, string FavColor, int FavNumber)
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Fav Color: {FavColor}");
            Console.WriteLine($"Fav Number: {FavNumber}");
            ViewBag.Name = Name;
            ViewBag.FavColor = FavColor;
            ViewBag.FavNumber = FavNumber;
            return View("Success");
        }
        [HttpGet("Success")]
        public IActionResult Success()
        {
            return View();
        }
    }
}