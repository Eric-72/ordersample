using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Order.Service;
using Order.Models;

namespace Order.Controllers
{
    public class HomeController : Controller
    {
        IOrderService _OrderService;

        public HomeController(IOrderService OrderService)
        {
            _OrderService = OrderService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Order()
        {
            List<OrderViewModel> model = new List<OrderViewModel>();

            IEnumerable<Data.Order> orders = _OrderService.GetAll();

            foreach (var item in orders)
            {
                model.Add(new OrderViewModel
                {
                    OrderId = item.OrderId,
                    OrderDate = item.OrderDate,
                    CustomerId = item.CustomerId,
                    Status = item.Status,
                    Comment = item.Comment
                });
            }

            return View(model);
        }

        [Authorize]
        public PartialViewResult OrderDetail(int Id)
        {
            List<OrderDetailViewModel> model = new List<OrderDetailViewModel>();

            IEnumerable<Data.OrderDetail> orderDetails = _OrderService.GetDetailsById(Id);

            foreach (var item in orderDetails)
            {
                model.Add(new OrderDetailViewModel
                {
                    OrderDetailId = item.OrderDetailId,
                    OrderId = item.OrderId,
                    ItemId = item.ItemId,
                    Quantity = item.Quantity,
                    Price = item.Price,
                    Total = item.Total
                });
            }

            return PartialView("_OrderDetail", model);
        }

        [Authorize]
        public ActionResult OrderAngular()
        {
            return View();
        }
    }
}