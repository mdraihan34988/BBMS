using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankSystem.Models
{
    public class MemberInfo : SearchMember     
    {
      

        public string Username { get; set; }

        public string Status { get; set; }

     
        public string Blood_Group { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Gender { get; set; }
       
        public string Profession { get; set; }
    }
}
