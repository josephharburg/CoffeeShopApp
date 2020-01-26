﻿using System;
using System.Collections.Generic;

namespace CoffeeShop.Models
{
    public partial class Items
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
    }
}