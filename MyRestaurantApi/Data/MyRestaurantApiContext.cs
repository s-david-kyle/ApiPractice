using Microsoft.EntityFrameworkCore;

namespace MyRestaurantApi.Data
{
    public class MyRestaurantApiContext : DbContext
    {
        public MyRestaurantApiContext(DbContextOptions<MyRestaurantApiContext> options)
            : base(options)
        {
        }

        public DbSet<MyRestaurantApi.Contact> Contact { get; set; } = default!;
        public DbSet<MyRestaurantApi.MenuItemOrdered> MenuItemOrdered { get; set; } = default!;
        public DbSet<MyRestaurantApi.TogoOrder> TogoOrder { get; set; } = default!;
    }
}
