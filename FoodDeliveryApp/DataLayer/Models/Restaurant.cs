using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.DataLayer.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
        public String Street { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public String OpenHours { get; set; }

        [Required]
        public double DeliveryFee { get; set; }

        public ICollection<Order> Orders { get; set; }

        public ICollection<Menu> Menu { get; set; }
    }
}
