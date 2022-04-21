using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using QuotingDojo.Models;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(Quote newQuote)
        {
            if (ModelState.IsValid)
            {
                string sql = $@"INSERT INTO quotes (Content, Byline, CreatedAt)
                    VALUES ('{newQuote.Content}', '{newQuote.Byline}', NOW())";

                DbConnector.Execute(sql);
                return RedirectToAction("Quotes");
            }
            return View("Index");
        }
        [HttpGet("quotes")]
        public IActionResult Quotes()
        {
            ViewBag.Quotes = DbConnector.Query("SELECT * FROM quotes");
            return View();
        }
    }
}