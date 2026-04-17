using Microsoft.AspNetCore.Mvc;
using OrderGenerator.Application.Interfaces;

namespace OrderGenerator.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {

        private readonly ILogger<OrderController> _logger;

        private readonly IOrderService _orderService;
        public OrderController(ILogger<OrderController> logger, IOrderService orderService)
        {
            _logger = logger;
            _orderService = orderService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult>  GetAll()
        {
            var order = _orderService.GetAll();
            return Ok(order);
        }

        [HttpGet("Get/{symbol}")]
        public async Task<IActionResult> Get(string symbol)
        {
            var order = _orderService.Get(symbol);
            return Ok(order);
        }
    }
       
}
