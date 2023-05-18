using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryTracker.Models;
using System;

namespace BakeryTracker.Tests
{
    [TestClass]
    public class VendorTests
    {

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("vendor1", "Test vendor");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
            Vendor newVendor = new Vendor("vendor1", "Test vendor");
            Vendor newVendor2 = new Vendor("vendor2", "A second test vendor");

            List<Vendor> vendors = Vendor.GetAll();

            CollectionAssert.Contains(vendors, newVendor);
            CollectionAssert.Contains(vendors, newVendor2);
        }

        [TestMethod]
        public void ClearAll_ClearsAllVendorObjects_VendorList()
        {
            Vendor newVendor = new Vendor("vendor1", "Test vendor");
            Vendor.ClearAll();
            List<Vendor> vendors = Vendor.GetAll();
            Assert.AreEqual(0, vendors.Count);
        }

        [TestMethod]
        public void Find_ReturnsCorrectVendor_Vendor()
        {
            Vendor.ClearAll();
            Vendor newVendor1 = new Vendor("Vendor 1", "Description 1");
            Vendor newVendor2 = new Vendor("Vendor 2", "Description 2");
            Vendor foundVendor = Vendor.Find(2);
            Assert.AreEqual(newVendor2, foundVendor);
        }

        [TestMethod]
        public void AddOrder_AddsOrderToVendor_OrdersList()
        {
            Vendor.ClearAll();
            Vendor vendor = new Vendor("Vendor 1", "Description 1");
            Order newOrder = new Order("Title", "Test", 99, DateOnly.MinValue);
            vendor.AddOrder(newOrder);
            CollectionAssert.Contains(vendor.Orders, newOrder);
        }




    }
}