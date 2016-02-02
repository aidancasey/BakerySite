using Bakery.Models;
using System.Data.Entity;

namespace Bakery.DataAccess
{
    public class BakeryContext : DbContext
    {
        public BakeryContext()
            : base() { }

        public DbSet<Product> Products { get; set; }
    }
}