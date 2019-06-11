using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRRCmanagement
{
    public class rentals
    {
        public string car_rego { get; set; }
        public int customerID { get; set; }
        public string CustomerName { get; set; }
        public string DateOfRental { get; set; }
        public int RentalDuration { get; set; }
        public rentals()
        { }
    }
}
