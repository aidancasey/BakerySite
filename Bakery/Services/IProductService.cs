using Bakery.Models;
using System.Collections.Generic;

namespace Bakery.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
    }
}
