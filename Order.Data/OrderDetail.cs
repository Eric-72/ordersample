using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Data
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ItemId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Total { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}
