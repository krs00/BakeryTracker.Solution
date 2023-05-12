using System.Collections.Generic;

namespace BakeryTracker.Models
{
    public class Order
    {
        public string Details { get; set; }
        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };
        private Order(string details )
        {
            Details = details;
            Id = _instances.Count; 

        }
    }
}