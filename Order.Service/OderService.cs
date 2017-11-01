using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Data;
using System.Data.Entity;

namespace Order.Service
{
    public class OrderService: IOrderService
    {
        IOrderDbContext _Context; 

        public OrderService(IOrderDbContext Context)
        {
            _Context = Context;
        }

        public IEnumerable<Data.Order> GetAll()
        {
            return _Context.Orders.ToList();
        }

        public Data.Order GetById(int Id)
        {
            return _Context.Orders.Where(x => x.OrderId == Id).FirstOrDefault();
        }

        public IEnumerable<Data.OrderDetail> GetDetailsById(int Id)
        {
            return _Context.OrderDetails.Where(x => x.OrderId == Id).ToList();
        }

    }
}
