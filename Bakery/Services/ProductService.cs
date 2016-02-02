using Bakery.DataAccess;
using Bakery.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

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
            //fake a slow running operation for id =2

            int counter= 0;
            if (id==2)
            {
                for (int i = 0; i <= 50000;i++)
                {
                    counter ++;
                    Debug.WriteLine(counter.ToString());
                }
            }

            using (BakeryContext context = new BakeryContext()) 
            {
                return context.Products.Find(id);
            }
        }
    }
}