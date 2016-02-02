using Bakery.DataAccess;
using Bakery.Models;
using System;
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
            if (id==2)
            {

                DateTime now = DateTime.Now;

                int k = 1;

                while (DateTime.Now.Subtract(now) < TimeSpan.FromSeconds(5))
                {
                    for (int i = 0; i <= 50000; i++)
                    {
                        k += i;
                    }
                }
            }

            using (BakeryContext context = new BakeryContext()) 
            {
                return context.Products.Find(id);
            }
        }
    }
}