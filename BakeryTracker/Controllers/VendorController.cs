using Microsoft.AspNetCore.Mvc;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

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

        [HttpPost("/vendor")]
        public ActionResult Create(string vendorName, string vendorDescription)
        {
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendor/{id}")]
        public ActionResult Show(int id)
        {
            // Using a dictionary to pass vendor list and order list
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            List<Order> vendorOrders = selectedVendor.Orders;
            model.Add("vendor", selectedVendor);
            model.Add("orders", vendorOrders);
            return View(model);
        }

        [HttpPost("/vendor/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string title, string description, decimal price, DateTime date)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor currentVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(title, description, price, date);
            currentVendor.AddOrder(newOrder);
            List<Order> vendorOrders = currentVendor.Orders;
            model.Add("orders", vendorOrders);
            model.Add("vendor", currentVendor);
            return View("Show", model);
        }


    }
}