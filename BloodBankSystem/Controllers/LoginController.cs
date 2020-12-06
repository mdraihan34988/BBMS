using BloodBankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankSystem.Controllers
{
    public class LoginController
    {
        static Database db = new Database();
        public static dynamic ValidateMember(string user,string pass)
        {
            
            return db.Members.ValidityMember(user,pass);
        }
        public static dynamic Validate(string user, string pass)
        {

            return db.Members.Validity(user, pass);
        }
    }
}
