using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class UserID
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public string preference { get; set; }

        public bool homeRoast { get; set; }
        public UserID()
        {

        }
        public void homeRoasting()
        {
            if(homeRoast == true)
            {
                
            }
        }
    }
}
