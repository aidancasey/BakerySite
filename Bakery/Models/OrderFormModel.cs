using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class OrderFormModel
    {
        public Product Product { get; set; }
        public int OrderQty { get; set; }
        [Required]
        public string OrderShipping { get; set; }
        [Required(ErrorMessage="You must provide an email address.")]
        public string OrderEmail { get; set; }
    }
}