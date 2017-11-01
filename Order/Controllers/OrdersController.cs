using Order.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Order.Controllers
{
    public class OrdersController : ApiController
    {
        IOrderService _OrderService;

        public OrdersController(IOrderService OrderService)
        {
            _OrderService = OrderService;
        }

        [Authorize]
        [Route("api/Orders/GetAll")]
        public HttpResponseMessage GetOrders()
        {
            var result = _OrderService.GetAll();

            if (result == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Orders Not Found");

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [Authorize]
        [Route("api/Orders/{Id}/GetDetails")]
        public HttpResponseMessage GetOrderDetails(int Id = 0)
        {
            if (Id <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            var result = _OrderService.GetDetailsById(Id);

            if (result == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Details Not Found");

            return Request.CreateResponse(HttpStatusCode.OK, result);
        }

    }
}
