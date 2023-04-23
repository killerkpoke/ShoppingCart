using Microsoft.EntityFrameworkCore;

namespace ShoppingCartListApi
{
    public class ShoppingCartDbContext: DbContext
    {
        public ShoppingCartDbContext(DbContextOptions<ShoppingCartDbContext> options): base(options)
        {
        }

        public DbSet<ShoppingCart> shoppingCart { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ShoppingCart>().HasData(
                new ShoppingCart
                {
                    Id = 1,
                    isPickedUp = false,
                    ItemName = "Banana",
                    Quantity = 3,
                },
                 new ShoppingCart
                 {
                     Id = 2,
                     isPickedUp = false,
                     ItemName = "Orange",
                     Quantity = 5,
                 },
                  new ShoppingCart
                  {
                      Id = 3,
                      isPickedUp = true,
                      ItemName = "Apple",
                      Quantity = 2,
                  }
                );
        }
    }
}