using OrderGenerator.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderGenerator.Application.Interfaces
{
    public interface IOrderRepository
    {
        void Add(Order order);
        decimal Get(string symbol);
        Dictionary<string, decimal> GetAll();
    }
}
