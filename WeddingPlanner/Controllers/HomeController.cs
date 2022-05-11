using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Controllers
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
            return View();
        }

        [HttpPost("users/create")]
        public IActionResult CreateUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(s => s.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                if (_context.Users.Any(s => s.FirstName == newUser.FirstName))
                {
                    ModelState.AddModelError("FirstName", "First Name already in use!");
                    return View("Index");
                }
                if (_context.Users.Any(s => s.LastName == newUser.LastName))
                {
                    ModelState.AddModelError("LastName", "Last Name already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Users.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("users/login")]
        public IActionResult Login(LoginUser loginUser)
        {
            if (ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(d => d.Email == loginUser.LoginEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            } else{
                return View("Index");
            }
        }

        [HttpGet("Dashboard")]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.AllWeddings = _context.Weddings.Include(s =>s.GuestsList).ToList();
            ViewBag.LoggedIn = _context.Users.Include(s => s.WeddingsPlan).Include(a => a.WeddingsAttend).ThenInclude(s => s.Wedding).FirstOrDefault(a => a.UserId == HttpContext.Session.GetInt32("UserId"));
            return View();
        }

        [HttpPost("order/add")]
        public IActionResult AddOrder(Order newOrder)
        {
                _context.Orders.Add(newOrder);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
        }

        [HttpPost("order/remove")]
        public IActionResult RemoveOrder(Order oldOrder)
        {
            Order OrderToDelete = _context.Orders.SingleOrDefault(a => a.WeddingId == oldOrder.WeddingId && a.UserId==oldOrder.UserId);
            _context.Orders.Remove(OrderToDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("weddings/add")]
        public IActionResult AddWedding()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpPost("weddings/new")]
        public IActionResult NewWedding(Wedding newWedding)
        {
            if(ModelState.IsValid)
            {
                newWedding.UserId = (int)HttpContext.Session.GetInt32("UserId");
                _context.Weddings.Add(newWedding);
                _context.SaveChanges();
                return Redirect($"/wedding/{newWedding.WeddingId}");
            } else{
                ViewBag.AllWeddings = _context.Weddings.OrderBy(a => a.WeddingId);
                return View("AddWedding");
            }
        }

        [HttpGet("wedding/{weddId}")]
        public IActionResult OneWedding(int weddId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Wedding = _context.Weddings.Include(a => a.Bride).Include(a => a.GuestsList).ThenInclude(d => d.Guest).FirstOrDefault(a => a.WeddingId == weddId);
            ViewBag.User = HttpContext.Session.GetInt32("UserId");
            ViewBag.AllUsers = _context.Users.OrderBy(a => a.UserId).ToList();
            ViewBag.WeddingsNotAttend = _context.Users.Include(f => f.WeddingsAttend).Where(s => s.WeddingsAttend.All(d => d.WeddingId != weddId)).ToList();
            return View();
        }

        [HttpGet("wedding/delete/{weddId}")]
        public IActionResult DeleteWedding(int weddId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            Wedding WeddToDelete = _context.Weddings.SingleOrDefault(a => a.WeddingId == weddId);
            _context.Weddings.Remove(WeddToDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("wedding/edit/{weddId}")]
        public IActionResult EditWedding(int weddId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            Wedding wedd = _context.Weddings.FirstOrDefault(a => a.WeddingId == weddId);
            return View(wedd);
        }

        [HttpPost("weddings/update/{weddId}")]
        public IActionResult UpdateWedding(int weddId, Wedding updatedVersion)
        {
            Wedding oldWedding = _context.Weddings.FirstOrDefault(a => a.WeddingId == weddId);
            if(ModelState.IsValid)
            {
            oldWedding.WeddingOne = updatedVersion.WeddingOne;
            oldWedding.WeddingTwo = updatedVersion.WeddingTwo;
            oldWedding.WeddingDate = updatedVersion.WeddingDate;
            oldWedding.WeddingAddress = updatedVersion.WeddingAddress;
            _context.SaveChanges();
            return Redirect($"/wedding/{weddId}");
            } else{
                return View("EditWedding", oldWedding);
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
