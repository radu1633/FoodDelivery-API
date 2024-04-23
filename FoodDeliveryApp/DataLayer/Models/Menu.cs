using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.DataLayer.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }

        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }

        [ForeignKey("MenuItem")]
        public int MenuItemId { get; set; }

        [Required]
        public String Availability { get; set; }

        [Required]
        public double Price { get; set; }

        public String Description { get; set; }

        public Restaurant Restaurant { get; set; }

        public MenuItem Item { get; set; }

        public ICollection<OrderDetails> Details { get; set; }
    }
}
