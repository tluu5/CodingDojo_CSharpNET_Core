using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using crudDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace crudDemo.Controllers
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
            ViewBag.AllPets = _context.Pets.OrderBy(d => d.Name).ToList();
            return View();
        }

        [HttpPost("pets/add")]
        public IActionResult AddPet(Pet newPet)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newPet);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else{
                return View("Index");
            }
        }

        [HttpGet("pets/remove/{petId}")]
        public IActionResult RemovePet(int petId)
        {
            Pet PetToRemove = _context.Pets.SingleOrDefault(s => s.PetId == petId);
            _context.Pets.Remove(PetToRemove);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("pets/edit/{petId}")]
        public IActionResult EditPet(int petId)
        {
            Pet PetToUpdate = _context.Pets.FirstOrDefault(a => a.PetId == petId);
            return View(PetToUpdate);
        }

        [HttpPost("pets/update/{petId}")]
        public IActionResult UpdatePet(int petId, Pet updatedPet)
        {
            if(ModelState.IsValid)
            {
                Pet OldPet = _context.Pets.FirstOrDefault(a => a.PetId == petId);
                OldPet.Name = updatedPet.Name;
                OldPet.Species = updatedPet.Species;
                OldPet.UpdatedAt = DateTime.Now;
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else{
                return View("EditPet", updatedPet);
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
