﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int AlbumID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Game Game { get; set; }
        public virtual Order Order { get; set; }
    }
}