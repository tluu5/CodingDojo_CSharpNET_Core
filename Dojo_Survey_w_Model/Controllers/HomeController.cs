using System;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("process")]
        public IActionResult ProcessForm(Survey result)
        {

            // passing result as view model
            return View("Result", result);
        }
    }
}