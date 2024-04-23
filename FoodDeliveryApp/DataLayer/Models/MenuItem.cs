using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryApp.DataLayer.Models
{
    public class MenuItem
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public String Name { get; set; }

        public ICollection<Menu> Menus { get; set; }
    }
}
