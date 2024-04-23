using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.DataLayer.Models
{
    public class Adress
    {
        [Key]
        public int AdressId { get; set; }

        [Required]
        public String Street { get; set; }

        [Required]
        public int Number { get; set; }

        public String Details { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
