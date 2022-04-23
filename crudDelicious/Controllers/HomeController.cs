using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crudDelicious.Models;

namespace crudDelicious.Controllers
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
            ViewBag.AllDishes = _context.Dishes.OrderByDescending(p => p.DishId).ToList();
            return View();
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish(Dish newDish)
        {
            return View("NewDish");
        }

        [HttpPost("dishes/add")]
        public IActionResult AddDish(Dish addDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(addDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else{
                return View("Index");
            }
        }

        [HttpGet("dishes/single/{dishId}")]
        public IActionResult SingleDish(int dishId)
        {
            Dish DishToSingle = _context.Dishes.FirstOrDefault(s => s.DishId == dishId);
            return View(DishToSingle);
        }

        [HttpGet("dishes/remove/{dishId}")]
        public IActionResult RemoveDish(int dishId)
        {
            Dish DishToRemove = _context.Dishes.SingleOrDefault(r => r.DishId == dishId);
            _context.Dishes.Remove(DishToRemove);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("dishes/edit/{dishId}")]
        public IActionResult EditDish(int dishId)
        {
            Dish DishToUpdate = _context.Dishes.FirstOrDefault(a => a.DishId == dishId);
            return View(DishToUpdate);
        }

        [HttpPost("dishes/update/{dishId}")]
        public IActionResult UpdateDish(int dishId, Dish updatedDish)
        {
            if(ModelState.IsValid)
            {
                Dish OldDish = _context.Dishes.FirstOrDefault(a => a.DishId == dishId);
                OldDish.Name = updatedDish.Name;
                OldDish.Chef = updatedDish.Chef;
                OldDish.Calories = updatedDish.Calories;
                OldDish.Tastiness = updatedDish.Tastiness;
                OldDish.Description = updatedDish.Description;
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else{
                return View("EditDish", updatedDish);
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
