namespace Order.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OrderDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OrderDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            /* context.Orders.AddOrUpdate(
            new Data.Order
            {
                OrderDate = new DateTime(2017, 5, 1),
                CustomerId = 1023,
                Status = 1,
                Comment = "this is the first order"
            },
            new Data.Order
            {
                OrderDate = new DateTime(2017, 6, 2),
                CustomerId = 112,
                Status = 1,
                Comment = "this is the Second order"
            },
            new Data.Order
            {
                OrderDate = new DateTime(2017, 7, 1),
                CustomerId = 456,
                Status = 1,
                Comment = "this is the third order"
            },
            new Data.Order
            {
                OrderDate = new DateTime(2017, 8, 1),
                CustomerId = 345,
                Status = 1,
                Comment = "this is the forth order"
            },
            new Data.Order
            {
                OrderDate = new DateTime(2017, 9, 1),
                CustomerId = 123,
                Status = 1,
                Comment = "this is the fifth order"
            }); */

            /*    context.OrderDetails.AddOrUpdate(
                new Data.OrderDetail
                {
                    OrderId = 1,
                    ItemId = 100003,
                    Quantity = 2,
                    Price = 5.50M,
                    Total = 2 * 5.50M
                },
                new Data.OrderDetail
                {
                    OrderId = 1,
                    ItemId = 100004,
                    Quantity = 2,
                    Price = 2.50M,
                    Total = 2 * 2.50M
                },
                new Data.OrderDetail
                {
                    OrderId = 1,
                    ItemId = 100005,
                    Quantity = 1,
                    Price = 1.50M,
                    Total = 1 * 1.50M
                },

                new Data.OrderDetail
                {
                    OrderId = 2,
                    ItemId = 100401,
                    Quantity = 1,
                    Price = 1.00M,
                    Total = 1 * 1.00M
                },
                new Data.OrderDetail
                {
                    OrderId = 2,
                    ItemId = 100703,
                    Quantity = 5,
                    Price = 3.50M,
                    Total = 5 * 3.50M
                }, 

                new Data.OrderDetail
                {
                    OrderId = 3,
                    ItemId = 100500,
                    Quantity = 2,
                    Price = 5.50M,
                    Total = 2 * 5.50M
                },
                new Data.OrderDetail
                {
                    OrderId = 3,
                    ItemId = 100503,
                    Quantity = 4,
                    Price = 1.50M,
                    Total = 4 * 1.50M
                },

                new Data.OrderDetail
                {
                    OrderId = 4,
                    ItemId = 100900,
                    Quantity = 1,
                    Price = 6.50M,
                    Total = 1 * 6.50M
                },
                new Data.OrderDetail
                {
                    OrderId = 4,
                    ItemId = 100903,
                    Quantity = 1,
                    Price = 5.50M,
                    Total = 1 * 5.50M
                },
                new Data.OrderDetail
                {
                    OrderId = 4,
                    ItemId = 100303,
                    Quantity = 1,
                    Price = 2.50M,
                    Total = 1 * 2.50M
                },

                new Data.OrderDetail
                {
                    OrderId = 5,
                    ItemId = 100603,
                    Quantity = 3,
                    Price = 1.50M,
                    Total = 3 * 1.50M
                });   */
        }
    }
}
