using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormValidations.Models;

namespace FormValidations.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]       
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("submit")]

        public IActionResult FormResult(Survey newsurvey)
            {   if (ModelState.IsValid)
                {
                    ViewBag.Survey=newsurvey;
                    return View();}
                else {
                    return View("Index");
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
