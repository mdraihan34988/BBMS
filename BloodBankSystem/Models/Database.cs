using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankSystem.Models
{
    public class Database
    {
        public Members Members { get; set; }
        public BloodStocks BloodStocks { get; set; }

        public BloodDonors BloodDonors { get; set; }
        public Requests Requests { get; set; }

        public Database()
        {
            Members = new Members();
            BloodStocks = new BloodStocks();
            BloodDonors = new BloodDonors();
            Requests = new Requests();
        }
    }
}
