namespace Bakery.Models
{
    public class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public string ShippingAddress { get; set; }
        public string EmailAddress { get; set; }
    }
}