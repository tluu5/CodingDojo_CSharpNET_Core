using Microsoft.AspNetCore.Mvc;

namespace FirstWebPage.Controllers
{
    public class FirstController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            string[] myArray = new string[] {"One", "Two", "Three"};
            ViewBag.StringArray = myArray;
            return View("Index");
        }
        [HttpGet]
        [Route("second")]
        public ViewResult Second()
        {
            ViewBag.myVariable = "This is coming from my viewbag";
            return View("Second");
        }
        [HttpGet("redirect")]
        public RedirectToActionResult Redirect()
        {
            return RedirectToAction("Second");
        }
        [HttpGet("form")]
        public ViewResult Form()
        {
            return View();
        }
        [HttpPost("postForm")]
        public IActionResult postForm()
        {
            return RedirectToAction("Success");
        }
        [HttpGet("Success")]
        public IActionResult Success()
        {
            return View();
        }
    }
}