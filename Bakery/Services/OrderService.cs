using Bakery.Models;

namespace Bakery.Services
{
    public class OrderService : IOrderService 
    {
        public void ProcessOrder(Order order) 
        {
            IMailService service = new MailService();
            service.SendOrderConfirmation(order);
        }
    }
}