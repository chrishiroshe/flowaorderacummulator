using OrderGenerator.Web.Models;

namespace OrderGenerator.Web.Interfaces
{
    public interface IFixSender
    {
        void Send(OrderViewModel model);
    }
}
