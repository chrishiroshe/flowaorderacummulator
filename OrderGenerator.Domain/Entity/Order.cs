using OrderGenerator.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderGenerator.Domain.Entity
{
    public class Order
    {
        public string Symbol { get; set; } 
        public SaleType SaleType { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
