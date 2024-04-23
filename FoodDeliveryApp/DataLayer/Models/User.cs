using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.DataLayer.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public String Password { get; set; }

        [Required]
        public String PhoneNumber { get; set; }

        [Required]
        public String Type { get; set; }

        public ICollection<Order> Orders;
    }
}
