using Microsoft.AspNetCore.Mvc;
using BakeryTracker.Models; 
using System.Collections.Generic;

namespace BakeryTracker.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View(); 
        }

    }
}