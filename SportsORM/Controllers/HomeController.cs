using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues.Where(l => l.Sport.Contains("Baseball")).ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.AllWomen = _context.Leagues.Where(d => d.Name.Contains("Women")).ToList();
            ViewBag.AllHockey = _context.Leagues.Where(d => d.Sport.Contains("Hockey")).ToList();
            ViewBag.AllNotfootball = _context.Leagues.Where(d => d.Sport != "Football").ToList();
            ViewBag.Conference = _context.Leagues.Where(d => d.Name.Contains("Conference")).ToList();
            ViewBag.Atlantic = _context.Leagues.Where(d => d.Name.Contains("Atlantic")).ToList();
            ViewBag.Dallas = _context.Teams.Where(d => d.Location.Contains("Dallas")).ToList();
            ViewBag.Raptors = _context.Teams.Where(d => d.TeamName.Contains("Raptors")).ToList();
            ViewBag.City = _context.Teams.Where(d => d.Location.Contains("City")).ToList();
            ViewBag.TNames = _context.Teams.Where(d => d.TeamName.Contains("T")).ToList();
            ViewBag.OrderLocation = _context.Teams.OrderBy(d => d.Location).ToList();
            ViewBag.TeamRevOrder = _context.Teams.OrderByDescending(d => d.TeamName).ToList();
            ViewBag.Cooper = _context.Players.Where(d => d.LastName.Contains("Cooper")).ToList();
            ViewBag.Joshua = _context.Players.Where(d => d.FirstName.Contains("Joshua")).ToList();
            ViewBag.CooperJ = _context.Players.Where(d => d.LastName.Contains("Cooper") && d.FirstName != "Joshua");
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}