using OrderGenerator.Application.Interfaces;
using OrderGenerator.Domain.Entity;
using OrderGenerator.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderGenerator.Infraestructure.Repositories.OrderRepository;

namespace OrderGenerator.Infraestructure.Repositories
{
    public class OrderRepository: IOrderRepository
    {

        private readonly Dictionary<string, decimal> _operation = new Dictionary<string, decimal>();

        public void Add(Order order)
        {
            if (order != null)
            {
                var ammount = order.Quantity * order.Price;
                if (order.SaleType == SaleType.Sell)
                {
                    ammount *= -1;
                }

                if (!_operation.ContainsKey(order.Symbol))
                {
                    _operation.Add(order.Symbol, 0);
                }
                _operation[order.Symbol] += ammount;
            }
          
        }

        public decimal Get(string symbol)
        {
            return _operation.TryGetValue(symbol, out var ammount) ? ammount : 0;
        }


        public Dictionary<string, decimal> GetAll()
        {
            return _operation;
        }

    }
}

