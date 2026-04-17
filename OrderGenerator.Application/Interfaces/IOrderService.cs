using OrderGenerator.Domain.Entity;

namespace OrderGenerator.Application.Interfaces
{
    public interface IOrderService
    {
        void Add(Order order);
        decimal Get (string symbol);
        Dictionary<string, decimal> GetAll();
    }
}
