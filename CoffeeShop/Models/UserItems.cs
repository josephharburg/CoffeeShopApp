using System;
using System.Collections.Generic;

namespace CoffeeShop.Models
{
    public partial class UserItems
    {
        public int UserItemId { get; set; }
        public int UserId { get; set; }
        public string ItemId { get; set; }

        public virtual Items Item { get; set; }
        public virtual Users User { get; set; }
    }
}
