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
        /*  This list will hold all "Order" objects that belong to each instance
            of the Vendor class */
        public List<Order> Order { get; set; }
        //  Name for each vendor created
        public string Name { get; set; }
        //  Description of each vendor created
        public string About { get; set; }

        /*  This is the constructor that builds the instance of Vendor 
            (blueprint for Vendor class) */ 
        public Vendor(string vendorName, string vendorDescription)
        {
            Name = vendorName;
            About = vendorDescription;

        }

    }
}