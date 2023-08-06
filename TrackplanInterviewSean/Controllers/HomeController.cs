using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrackplanInterviewSean.Models;

namespace TrackplanInterviewSean.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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


        public ActionResult PageOne()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PageTwo(string word) 
        {
            ViewBag.Word = word;
            return View();
        }
    }
}