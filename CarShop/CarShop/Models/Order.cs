using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        [Required(ErrorMessage ="PLease enter the name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the city.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the phone number.")]
        public string PhoneNumber { get; set; }


        public decimal OrderTotal { get; set; }

        public DateTime OrderPlaced { get; set; }

    }
}
