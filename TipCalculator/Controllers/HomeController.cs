using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TipCalculator.Models;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Fifteen = 0;
            ViewBag.Twenty = 0;
            ViewBag.TwentyFive = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(TipCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Fifteen = model.CalculateFifteenTip();
                ViewBag.Twenty = model.CalculateTwentyTip();
                ViewBag.TwentyFive = model.CalculateTwentyFiveTip();
            }
            else
            {
                ViewBag.Fifteen = 0;
                ViewBag.Twenty = 0;
                ViewBag.TwentyFive = 0;
            }
            return View(model);
        }
    }
}