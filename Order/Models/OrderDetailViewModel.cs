using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Order.Models
{
    public class OrderDetailViewModel
    {
        public int OrderDetailId { get; set; }
                
        public int OrderId { get; set; }
                
        public int ItemId { get; set; }
                
        public int Quantity { get; set; }
                
        public decimal Price { get; set; }
                
        public decimal Total { get; set; }
        
    }
}