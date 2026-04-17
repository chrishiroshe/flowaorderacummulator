using Microsoft.AspNetCore.Mvc;
using OrderGenerator.Web.Interfaces;
using OrderGenerator.Web.Models;
using System.Diagnostics;

namespace OrderGenerator.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly IFixSender _fixSender;

        public OrderController(ILogger<OrderController> logger, IFixSender fixSender)
        {
            _logger = logger;
            _fixSender = fixSender;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(new OrderViewModel());
        }
        [HttpPost]
        public IActionResult Index(OrderViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                _fixSender.Send(model);
                model.ResultMessage = "Order Sent Successfully";

            }
            catch (Exception ex)
            {
                model.ResultMessage = $"Order Failed:{ ex.Message }";
            }

            return View(model);
        }
     
    }
}
