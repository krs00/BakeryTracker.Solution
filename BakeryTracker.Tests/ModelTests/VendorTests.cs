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

    }
}