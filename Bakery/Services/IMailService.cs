using Bakery.Models;

namespace Bakery.Services
{
    public interface IMailService
    {
        void SendOrderConfirmation(Order order);
    }
}
