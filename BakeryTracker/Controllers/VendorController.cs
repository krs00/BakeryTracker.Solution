using Microsoft.AspNetCore.Mvc;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Controllers
{
    public class VendorController : Controller
    {

        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> vendors = Vendor.GetAll();
            return View(vendors);
        }


        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName, string vendorDescription)
        {
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor currentVendor = Vendor.Find(id);
            List<Order> vendorItems = currentVendor.Orders;
            model.Add("vendor", currentVendor);
            model.Add("orders", vendorItems);
            return View(model);
        }

        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string orderTitle, string orderDescription, decimal orderPrice, DateTime orderDate)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor locatedVendor = Vendor.Find(vendorId);
            DateOnly orderDateOnly = DateOnly.FromDateTime(orderDate);
            Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDateOnly);
            locatedVendor.AddOrder(newOrder);
            List<Order> categoryOrders = locatedVendor.Orders;
            model.Add("vendor", locatedVendor);
            model.Add("orders", categoryOrders);
            return View("Show", model);
        }




    }
}