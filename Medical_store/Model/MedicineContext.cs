using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Medical_store.Model
{
    public class MedicineContext : DbContext
    {
        public MedicineContext(DbContextOptions<MedicineContext> options)
            : base(options) { }
        public DbSet<Medicine> Medicine { get; set; } = null!;
        public DbSet<User> users { get; set; } = null!;
        public DbSet<Order> orders { get; set; } = null!;
        public DbSet<Order_Item> order_Items { get; set; } = null!;
        public DbSet<Cart> Carts { get; set; } = null!;

    }
}
