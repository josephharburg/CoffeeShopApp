using System;
using System.Collections.Generic;

namespace CoffeeShop.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Preference { get; set; }
        public bool? HomeRoast { get; set; }
    }
}
