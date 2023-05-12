using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryTracker.Models;
using System;

namespace BakeryTracker.Tests
{
    [TestClass]
    public class VendorTests // : IDisposable     (for teardown)
    {

        // public void Dispose()
        // { 
        //     Vendor.ClearAll();
        // }

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
    }
}