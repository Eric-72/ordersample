using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Data
{
    [Table("Order")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public byte Status { get; set; }

        [MaxLength(150)]
        public string Comment { get; set; }

        
    }
}
