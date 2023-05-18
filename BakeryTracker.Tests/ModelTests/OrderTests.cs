using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryTracker.Models;
using System;

namespace BakeryTracker.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("Test Order", "Test description", 9.99m, new DateOnly(2023, 5, 17));
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetAll_ReturnsAllOrderObjects_OrderList()
        {
            Order.ClearAll();
            Order newOrder1 = new Order("Order 1", "Description 1", 9.99m, new DateOnly(2023, 5, 17));
            Order newOrder2 = new Order("Order 2", "Description 2", 19.99m, new DateOnly(2023, 5, 18));
            List<Order> orders = Order.GetAll();
            CollectionAssert.Contains(orders, newOrder1);
            CollectionAssert.Contains(orders, newOrder2);
        }

        [TestMethod]
        public void ClearAll_ClearsAllOrderObjects_OrderList()
        {
            Order newOrder = new Order("Order 1", "Description 1", 9.99m, new DateOnly(2023, 5, 17));
            Order.ClearAll();
            List<Order> orders = Order.GetAll();
            Assert.AreEqual(0, orders.Count);
        }

        [TestMethod]
        public void Find_ReturnsCorrectOrder_Order()
        {
            Order.ClearAll();
            Order newOrder1 = new Order("Order 1", "Description 1", 9.99m, new DateOnly(2023, 5, 17));
            Order newOrder2 = new Order("Order 2", "Description 2", 19.99m, new DateOnly(2023, 5, 18));
            Order foundOrder = Order.Find(2);
            Assert.AreEqual(newOrder2, foundOrder);
        }
    }
}
