using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Data
{
    public class OrderDbContext : DbContext, IOrderDbContext
    {
        public OrderDbContext() : base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Data.Order> Orders { get; set; }
        public IDbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
