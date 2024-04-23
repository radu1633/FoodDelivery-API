using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.DataLayer.Models
{
    public class DeliveryPerson
    {
        [Key]
        public int DeliveryPersonId { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Email { get; set; }

        [Required]
        public String Password { get; set; }

        [Required]
        public String Vehicle { get; set; }

        [Required]
        public String PhoneNumber { get; set; }

        [Required]
        public String Availability { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}

