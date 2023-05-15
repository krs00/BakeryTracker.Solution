using System.Collections.Generic;
// Hi my name is Kymani and I'm going to comment my code!
/*  It is for learning purposes, also to create a habit for
    documentation purposes */
namespace BakeryTracker.Models
{
    public class Vendor
    {
        /*  This private list will hold all instances of the "Vendor"
            class that get created */
        private static List<Vendor> _instances = new List<Vendor> { };
        /*  This list will hold all "Order" objects that are created
            and belong to the instance
            of the Vendor class */
        public List<Order> Orders { get; set; }
        //  Name for each vendor created
        public string Name { get; set; }
        //  Description of each vendor created
        public string Description { get; set; }
        /*  This is a "read-only" property for each "Vendor" instance
            can have a unique ID */
        public int Id { get; }
        /*  This is the constructor that builds each instance of a "Vendor" object
            (blueprint for Vendor class) */
        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            /*  Adds each created instance of "Vendor" object to list named
                "_instances" ( Which is defined above ) */
            _instances.Add(this);
            /*  This will set the value of the Id property for each "Vendor" created 
                to a unique value (The current count of _instances list) */
            Id = _instances.Count;
            Orders = new List<Order>{}; 
        }


        //  Method will return list of all Vendor objects
        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Vendor Find(int searchId)
        {
            return _instances[searchId - 1];
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }

}