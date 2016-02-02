using Bakery.DataAccess;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Services
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
        {
            using (BakeryContext context = new BakeryContext())
            {
                return context.Products.ToList();
            }
        }

        public Product GetProduct(int id) 
        {
            using (BakeryContext context = new BakeryContext()) 
            {
                return context.Products.Find(id);
            }
        }
    }
}