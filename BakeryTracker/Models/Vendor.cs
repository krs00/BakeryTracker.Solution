using System.Collections.Generic;

namespace BakeryTracker.Models
{
    public class Vendor
    {

        /* This private list will hold all instances of the "Vendor"
        class that get created */
        private static List<Vendor> _instances = new List<Vendor> { };
        // Name for each vendor
        public string Name { get; set; }
        // Description of each vendor
        public string About { get; set; }

        public Vendor(string vendorName, string vendorDescription)
        {

        }

    }
}