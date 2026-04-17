using OrderGenerator.Application.Interfaces;
using OrderGenerator.Domain.Entity;
using OrderGenerator.Domain.Enum;
using QuickFix;
using QuickFix.Fields;
using QuickFix.FIX44;
using Message = QuickFix.FIX44.Message;

namespace OrderGenerator.Infraestructure.Fix
{
    public class FixApplication: MessageCracker, IApplication
    {
        private readonly IOrderService _orderService;
        public FixApplication( IOrderService orderService)
        { 
           _orderService = orderService;
        }

        public void FromAdmin(Message message, SessionID sessionID)
        {
            throw new NotImplementedException();
        }
       
        public void OnMessage(NewOrderSingle message, SessionID sessionID)
        {
            var order = new Order()
            {
                Symbol = message.Symbol.getValue(),
                Quantity = (int)message.OrderQty.getValue(),
                Price = message.Price.getValue(),
                SaleType = message.Side.getValue() == Side.BUY ? SaleType.Buy : SaleType.Sell
            };

             _orderService.Add(order);
        }

        public void OnCreate(SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void OnLogon(SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void OnLogout(SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void ToAdmin(Message message, SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void ToApp(Message message, SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void ToAdmin(QuickFix.Message message, SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void FromAdmin(QuickFix.Message message, SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void ToApp(QuickFix.Message message, SessionID sessionID)
        {
            throw new NotImplementedException();
        }

        public void FromApp(QuickFix.Message message, SessionID sessionID)
        {
            Crack(message, sessionID);
        }
    }
}
