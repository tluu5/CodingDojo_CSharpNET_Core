using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsandCategories.Models;
using Microsoft.EntityFrameworkCore;

namespace ProductsandCategories.Controllers
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
            ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();
            return View();
        }

        [HttpPost("product/add")]
        public IActionResult AddProduct(Product newProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(newProduct);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();
                return View("Index");
            }
        }

        [HttpGet("product/{proId}")]
        public IActionResult OneProduct(int proId)
        {
            ViewBag.OneProduct = _context.Products.Include(s => s.ProductWithIn).ThenInclude(d => d.Category).FirstOrDefault(a => a.ProductId == proId);
            ViewBag.AllCategories = _context.Categories.OrderBy(a => a.Name).ToList();
            ViewBag.CategoriesNotWithIn = _context.Categories.Include(f => f.CategoryWithIn).Where(s => s.CategoryWithIn.All(d => d.ProductId != proId)).ToList();
            return View();
        }

        [HttpPost("association/add")]
        public IActionResult AddAssociation(Association newAssociation, string option)
        {
            _context.Associations.Add(newAssociation);
            _context.SaveChanges();
            if(option == "product")
            {
                return Redirect($"/product/{newAssociation.ProductId}");
            } else{
                return Redirect($"/category/{newAssociation.CategoryId}");
            }
        }

        [HttpGet("Categories")]
        public IActionResult Categories()
        {
            ViewBag.AllCategories = _context.Categories.OrderBy(a => a.Name).ToList();
            return View();
        }

        [HttpPost("category/add")]
        public IActionResult AddCategory(Category newCategory)
        {
            if(ModelState.IsValid)
            {
                _context.Categories.Add(newCategory);
                _context.SaveChanges();
                return RedirectToAction("Categories");
            } else{
                ViewBag.AllCategories = _context.Categories.OrderBy(a => a.Name).ToList();
                return View("Categories");
            }
        }

        [HttpGet("category/{catId}")]
        public IActionResult OneCategory(int catId)
        {
            ViewBag.OneCategory = _context.Categories.Include(s => s.CategoryWithIn).ThenInclude(d => d.Product).FirstOrDefault(a => a.CategoryId == catId);
            ViewBag.AllProducts = _context.Products.OrderBy(a => a.Name).ToList();
            ViewBag.ProductsNotWithIn = _context.Products.Include(f => f.ProductWithIn).Where(s => s.ProductWithIn.All(d => d.CategoryId != catId)).ToList();
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
