using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using linqDemo.Models;

namespace linqDemo.Controllers
{
    public class HomeController : Controller
    {
        public Pet[] AllPets = new Pet[]
        {
            new Pet {Name = "Giselle", Species = "Cat", Breed = "British Short Hair", Age = 1, LoveCuddle = true},
            new Pet {Name = "Oreo", Species = "Dog", Breed = "Lab Mix", Age = 1, LoveCuddle = true},
            new Pet {Name = "Thora", Species = "Cat", Breed = "Ragdoll", Age = 16, LoveCuddle = true},
            new Pet {Name = "Violet", Species = "Cat", Breed = "Russian Blue", Age = 7, LoveCuddle = false},
            new Pet {Name = "Juniper", Species = "Cat", Breed = "Russian Blue", Age = 1, LoveCuddle = true},
            new Pet {Name = "Gravy", Species = "Cat", Breed = "Tabby", Age = 2, LoveCuddle = false},
            new Pet {Name = "Bouldy", Species = "Rock", Breed = "Boulder", Age = 24, LoveCuddle = true},
            new Pet {Name = "Bubber", Species = "Cat", Breed = "Tuxedo", Age = 2, LoveCuddle = true},
            new Pet {Name = "Budweiser", Species = "Dog", Breed = "Black Lab Mix", Age = 12, LoveCuddle = true},
            new Pet {Name = "Mazikeen", Species = "Dog", Breed = "Basset", Age = 4, LoveCuddle = true},
            new Pet {Name = "Kiwi", Species = "Bird", Breed = "Parrot", Age = 9001, LoveCuddle = false},
            new Pet {Name = "Channel", Species = "Dog", Breed = "Shitzu", Age = 8, LoveCuddle = true},
            new Pet {Name = "Ko", Species = "Dog", Breed = "GermanShepherd", Age = 5, LoveCuddle = true},
            new Pet {Name = "Greendawg", Species = "Pterodactyl", Breed = "Cropduster", Age = 450, LoveCuddle = true},
            new Pet {Name = "Torrent", Species = "House", Breed = "Spirit Steed", Age = 216, LoveCuddle = true}
        };
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.AllPets = AllPets.OrderBy(pet => pet.Name).OrderBy(l => l.Species).ToList();
            ViewBag.AllCats = AllPets.Where(d => d.Species == "Cat").ToList();
            ViewBag.Cuddles = AllPets.Where(f => f.LoveCuddle == true).ToList();
            ViewBag.AllLabs = AllPets.Where(s => s.Breed.Contains("Lab")).ToList();
            ViewBag.SelectBreed = AllPets.Select(g => g.Breed);
            ViewBag.FirstCat = AllPets.FirstOrDefault(g => g.Species == "Cat");
            ViewBag.BNames = AllPets.ToList().Where(g => g.Name[0] == 'B');
            ViewBag.TwentyNoCuddles = AllPets.Where(g => g.Age > 20 && g.LoveCuddle == true);
            return View();
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
