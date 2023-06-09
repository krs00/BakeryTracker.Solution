using System.Collections.Generic;
using System;

namespace BakeryTracker.Models
{
    public class Order
    { 
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateOnly Date { get; set; }
        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };
        public Order(string title, string description, decimal price, DateOnly date)
    {
        Title = title;
        Description = description;
        Price = price;
        Date = date; 
        Id = _instances.Count;
        _instances.Add(this);
    }

      public static void ClearAll()
    {
      _instances.Clear();
    }

      public static List<Order> GetAll()
    {
      return _instances;
    }

      public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }

    }
}