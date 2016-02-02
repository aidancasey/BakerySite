using Bakery.Models;
namespace Bakery.Services
{
    public interface IOrderService
    {
        void ProcessOrder(Order order);
    }
}
