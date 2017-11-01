using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Data;

namespace Order.Service
{
    public interface IOrderService
    {
        IEnumerable<Data.Order> GetAll();

        IEnumerable<OrderDetail> GetDetailsById(int Id);

        Data.Order GetById(int Id);
    }
}
