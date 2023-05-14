using Microsoft.AspNetCore.Mvc;
using BakeryTracker.Models;
using System.Collections.Generic;

namespace BakeryTracker.Controllers
{
    public class VendorController : Controller
    {

        [HttpGet("/vendor")] 
        public ActionResult Index()
        {
            List<Vendor> vendors = Vendor.GetAll();
            return View(vendors);  
        }


        [HttpGet("/vendor/new")] 
        public ActionResult New()
        {
            return View();
        }

    }
}