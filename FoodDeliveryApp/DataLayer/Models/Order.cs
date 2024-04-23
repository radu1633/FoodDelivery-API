using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.DataLayer.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }

        [ForeignKey("Adress")]
        public int AdressId { get; set; }

        [ForeignKey("DeliveryPerson")]
        public int DeliveryPersonId { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public String PaymentMethod { get; set; }

        [Required]
        public String Status { get; set; }

        [Required]
        public DateTime Date_Time { get; set; }

        public String Note { get; set; }

        public User User { get; set; }

        public Restaurant Restaurant { get; set; }

        public Adress Adress { get; set; }

        public DeliveryPerson DeliveryPerson { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
