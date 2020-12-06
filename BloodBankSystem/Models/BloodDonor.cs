using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankSystem.Models
{
    public class BloodDonor
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public int Donate_Serial { get; set; }
        public string Blood_Group { get; set; }
        public DateTime Last_Donate_Date { get; set; }
    }
}
