using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order;
using Order.Controllers;
using Order.Data;
using Order.Service;
using Moq;

namespace Order.Tests.Controllers
{
    [TestClass]
    public class OrdersControllerTest
    {
        [TestMethod]
        public void Orders_GetAll_ReturnsNotFound()
        {
            List<Data.Order> orders = null;

            var mockOrderService = new Mock<IOrderService>();
            mockOrderService.Setup(x => x.GetAll()).Returns(() => orders);

            var controller = new OrdersController(mockOrderService.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var response = controller.GetOrders();

            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }

        [TestMethod]
        public void Orders_GetAll_ReturnsOK()
        {
            var orders = new List<Data.Order>()
            {
                new Data.Order { OrderId = 100, OrderDate =new DateTime(2017, 10, 31), CustomerId = 202, Status = 1, Comment = "here comes the comments" },
                new Data.Order { OrderId = 99, OrderDate =new DateTime(2017, 10, 30), CustomerId = 223, Status = 1, Comment = "here comes the comments" }
            };

            var mockOrderService = new Mock<IOrderService>();
            mockOrderService.Setup(x => x.GetAll()).Returns(() => orders);

            var controller = new OrdersController(mockOrderService.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var response = controller.GetOrders();

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var actual = response.Content.ReadAsAsync<List<Data.Order>>().Result;
            Assert.AreEqual(orders.Count, actual.Count);
            
        }

        [TestMethod]
        public void Orders_GetDetails_ReturnsOK()
        {
            var orderDetails = new List<OrderDetail>()
            {
                new OrderDetail { OrderDetailId = 1001, OrderId = 100, ItemId = 10005, Quantity = 2, Price = 2.00M, Total = 4.00M },
                new OrderDetail { OrderDetailId = 1002, OrderId = 100, ItemId = 10006, Quantity = 1, Price = 3.00M, Total = 3.00M },
                new OrderDetail { OrderDetailId = 1003, OrderId = 100, ItemId = 10007, Quantity = 3, Price = 3.00M, Total = 9.00M }
            };

            var mockOrderService = new Mock<IOrderService>();
            mockOrderService.Setup(x => x.GetDetailsById(100)).Returns(() => orderDetails);

            var controller = new OrdersController(mockOrderService.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var response = controller.GetOrderDetails(100);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var actual = response.Content.ReadAsAsync<List<OrderDetail>>().Result;
            Assert.AreEqual(orderDetails.Count, actual.Count);
        }

        [TestMethod]
        public void Orders_GetDetails_ReturnsNotFound()
        {

            List<OrderDetail> orderDetails = null;

            var mockOrderService = new Mock<IOrderService>();
            mockOrderService.Setup(x => x.GetDetailsById(100)).Returns(() => orderDetails);

            var controller = new OrdersController(mockOrderService.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var response = controller.GetOrderDetails(100);

            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }

        [TestMethod]
        public void Orders_GetDetails_ReturnsBadRequest()
        {
            //OrderId is Zero

            var orderDetails = new List<OrderDetail>()
            {
                new OrderDetail { OrderDetailId = 1001, OrderId = 0, ItemId = 10005, Quantity = 2, Price = 2.00M, Total = 4.00M },
                new OrderDetail { OrderDetailId = 1002, OrderId = 0, ItemId = 10006, Quantity = 1, Price = 3.00M, Total = 3.00M },
                new OrderDetail { OrderDetailId = 1003, OrderId = 0, ItemId = 10007, Quantity = 3, Price = 3.00M, Total = 9.00M }
            };

            var mockOrderService = new Mock<IOrderService>();
            mockOrderService.Setup(x => x.GetDetailsById(0)).Returns(() => orderDetails);

            var controller = new OrdersController(mockOrderService.Object);
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();
            var response = controller.GetOrderDetails(0);

            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode);
        }
    }
}
