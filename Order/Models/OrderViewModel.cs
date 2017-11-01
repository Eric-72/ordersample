using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Order.Models
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }

        public byte Status { get; set; }
                
        public string Comment { get; set; }
    }
}