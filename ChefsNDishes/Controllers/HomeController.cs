using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs.Include(s => s.Meal).OrderBy(a =>a.FirstName).ToList();
            return View();
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {
            return View();
        }

        [HttpPost("chef/create")]
        public IActionResult AddChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                _context.Chefs.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else{
                return View("NewChef");
            }
        }

        [HttpGet("Dishes")]
        public IActionResult Dishes()
        {
            ViewBag.AllChefs = _context.Chefs.OrderBy(a => a.FirstName).ToList();
            ViewBag.AllDishes = _context.Dishes.Include(a => a.Worker).OrderBy(a => a.Name).ToList();
            return View();
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            ViewBag.AllChefs = _context.Chefs.OrderBy(a => a.FirstName).ToList();
            ViewBag.AllDishes = _context.Dishes.Include(a => a.Worker).OrderBy(a => a.Name).ToList();
            return View();
        }

        [HttpPost("dish/create")]
        public IActionResult AddDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Dishes.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Dishes");
            } else{
                ViewBag.AllChefs = _context.Chefs.OrderBy(a => a.FirstName).ToList();
                ViewBag.AllDishes = _context.Dishes.OrderBy(a => a.Name).ToList();
                return View("NewDish");
            }
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
