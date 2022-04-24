﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using oneToMany.Models;
using Microsoft.EntityFrameworkCore;

namespace oneToMany.Controllers
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
            ViewBag.AllArtists = _context.Artists.Include(s => s.Discography).OrderBy(a => a.Name).ToList();
            return View();
        }

        [HttpPost("artist/create")]
        public IActionResult AddArtist(Artist newArtist)
        {
            if(ModelState.IsValid)
            {
                _context.Artists.Add(newArtist);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else{
                return View("Index");
            }
        }

        [HttpGet("Songs")]
        public IActionResult Songs()
        {
            ViewBag.AllArtists = _context.Artists.OrderBy(a => a.Name).ToList();
            ViewBag.AllSongs = _context.Songs.Include(a => a.Performer).OrderBy(a => a.Title).ToList();
            return View();
        }

        [HttpPost("song/create")]
        public IActionResult AddSong(Song newSong)
        {
            if(ModelState.IsValid)
            {
                _context.Songs.Add(newSong);
                _context.SaveChanges();
                return RedirectToAction("Songs");
            } else{
                ViewBag.AllArtists = _context.Artists.OrderBy(a => a.Name).ToList();
                ViewBag.AllSongs = _context.Songs.OrderBy(a => a.Title).ToList();
                return View("Songs");
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
