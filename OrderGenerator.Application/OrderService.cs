using OrderGenerator.Application.Interfaces;
using OrderGenerator.Domain.Entity;
using OrderGenerator.Domain.Enum;

namespace OrderGenerator.Application
{
   public class OrderService: IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository ) {
            _orderRepository = orderRepository;
        }
        public void Add(Order order)
        {
            if (order != null)
            {
                _orderRepository.Add(order);
            }
        }

        public decimal Get(string symbol)
        {
            if (!String.IsNullOrEmpty(symbol))
            {
               return _orderRepository.Get(symbol);
            }
            return 0;
        }

          
        public Dictionary<string,decimal> GetAll()
        {
            return _orderRepository.GetAll();
        }
       
    }
}
