using BloodBankSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankSystem.Controllers
{
    public class BloodStockController
    {
        static Database db = new Database();
        public static ArrayList GetAllBloodGroup()
        {
            return db.BloodStocks.GetAllBloodGroup();
        }
        public static int CheckRequest(string bloodgroup,int quantity)
        {
            return db.BloodStocks.CheckRequest(bloodgroup, quantity);
        }
        public static void UpdateStock(string bloodgroup)
        {
            db.BloodStocks.UpdateStock(bloodgroup);
        }
    }
}
