using FoodDeliveryApp.DataLayer.Models;
using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryApp.DataLayer
{
    public class FoodDeliveryDb : DbContext
    {
        public FoodDeliveryDb(DbContextOptions<FoodDeliveryDb> options) : base(options) { }

        public DbSet<Adress> Adresses { get; set; }
        public DbSet<DeliveryPerson> DeliveryPeople { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
