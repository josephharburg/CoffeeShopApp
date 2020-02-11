using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public partial class Users
    {
        public Users()
        {
            UserItems = new HashSet<UserItems>();
        }

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        [StringLength(maximumLength: 20, MinimumLength = 8, ErrorMessage = "Your password must be 8-20 characters long, contain at least One Uppercase letter, One Lowercase Letter and One Number.")]
        public string Password { get; set; }
        public string Preference { get; set; }
        public bool? HomeRoast { get; set; }
        public decimal? Funds { get; set; }

        public virtual ICollection<UserItems> UserItems { get; set; }
    }
}
