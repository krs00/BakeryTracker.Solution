using Microsoft.AspNetCore.Mvc;
using BakeryTracker.Models;
using System;
using System.Collections.Generic;

namespace BakeryTracker.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
            Vendor vendor = Vendor.Find(vendorId);
            return View(vendor); 
        }

    }
}