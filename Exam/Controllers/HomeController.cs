using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exam.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Exam.Controllers
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
                if (_context.Users.Any(s => s.Name == newUser.Name))
                {
                    ModelState.AddModelError("Name", "Name already in use!");
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
            ViewBag.AllMeets = _context.Meets.Include(s =>s.GuestsList).Include(s => s.Creator).OrderByDescending(p => p.MeetId).ToList();
            ViewBag.LoggedIn = _context.Users.Include(s => s.MeetsPlan).Include(a => a.MeetsAttend).ThenInclude(s => s.Meet).FirstOrDefault(a => a.UserId == HttpContext.Session.GetInt32("UserId"));
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
            Order OrderToDelete = _context.Orders.SingleOrDefault(a => a.MeetId == oldOrder.MeetId && a.UserId==oldOrder.UserId);
            _context.Orders.Remove(OrderToDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("meets/add")]
        public IActionResult AddMeet()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost("meets/new")]
        public IActionResult NewMeet(Meet newMeet)
        {
            if(ModelState.IsValid)
            {
                newMeet.UserId = (int)HttpContext.Session.GetInt32("UserId");
                _context.Meets.Add(newMeet);
                _context.SaveChanges();
                return Redirect($"/meet/{newMeet.MeetId}");
            } else{
                ViewBag.AllMeets = _context.Meets.OrderBy(a => a.MeetId);
                return View("AddMeet");
            }
        }

        [HttpGet("meet/{meId}")]
        public IActionResult OneMeet(int meId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Meet = _context.Meets.Include(a => a.Creator).Include(a => a.GuestsList).ThenInclude(d => d.Guest).FirstOrDefault(a => a.MeetId == meId);
            ViewBag.User = HttpContext.Session.GetInt32("UserId");
            ViewBag.AllUsers = _context.Users.OrderBy(a => a.UserId).ToList();
            ViewBag.MeetsNotAttend = _context.Users.Include(f => f.MeetsAttend).Where(s => s.MeetsAttend.All(d => d.MeetId != meId)).ToList();
            ViewBag.AllMeets = _context.Meets.Include(a => a.Minutes).Include(a => a.Hours).Include(a => a.Days).Include(s =>s.GuestsList).ToList();
            ViewBag.LoggedIn = _context.Users.Include(s => s.MeetsPlan).Include(a => a.MeetsAttend).ThenInclude(s => s.Meet).FirstOrDefault(a => a.UserId == HttpContext.Session.GetInt32("UserId"));
            return View();
        }

        [HttpGet("meet/delete/{meId}")]
        public IActionResult DeleteMeet(int meId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index");
            }
            Meet MeToDelete = _context.Meets.SingleOrDefault(a => a.MeetId == meId);
            _context.Meets.Remove(MeToDelete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
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
