using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankSystem.Models
{
    public class Request
    {
        public int Order_Serial { get; set; }
        public string Username { get; set; }

        public string Blood_Group { get; set; }

        public int Quantity { get; set; }

        public string Order_Status { get; set; }

        public string Member_Status { get; set; }
        public int ServiceCharge { get; set; }






    }
}
