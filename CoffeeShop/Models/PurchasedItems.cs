using System;
using System.Collections.Generic;

namespace CoffeeShop.Models
{
    public partial class PurchasedItems
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public string ItemType { get; set; }
    }
}
