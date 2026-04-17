using OrderGenerator.Web.Interfaces;
using OrderGenerator.Web.Models;
using QuickFix;
using QuickFix.Fields;
using QuickFix.FIX44;

namespace OrderGenerator.Web.Services
{
    public class FixSender: IFixSender
    {
        private readonly SessionID _sessionId;

        public FixSender()
        {
            _sessionId = new SessionID("FIX 4.4", "ORDERGENERATOR" , "ORDERACUMULATOR");
        }

        public void Send(OrderViewModel model)
        {
            var operationType = model.OperationType.Equals("Buy", StringComparison.OrdinalIgnoreCase)?
                Side.BUY: Side.SELL;

            var order = new NewOrderSingle(new ClOrdID(Guid.NewGuid().ToString()),new Symbol(model.Symbol), new Side(operationType),
                new TransactTime(DateTime.UtcNow), new OrdType(OrdType.LIMIT));


            order.Set(new OrderQty(model.Quantity));

            order.Set(new Price(model.Price));

            Session.SendToTarget(order, _sessionId);
        }
    }
}
