using Duende.IdentityServer.EntityFramework.Options;
using Duende.IdentityServer.Events;
using FoodExpress.Server.Models;
using FoodExpress.Shared;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FoodExpress.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Food>().HasData(
                new Food { Id = 1, ImageUrl = "https://www.rohlik.cz/cdn-cgi/image/f=auto,fit=cover,g=0.5x0.5,w=2900,h=1300/https://cdn.rohlik.cz/images/meals/large/237.jpg", Name = "Pizza Margherita", Description = "Classic Neapolitan pizza with fresh mozzarella, tomatoes, and basil.", Price = 10.99 },
                new Food { Id = 2, ImageUrl = "https://www.sousviderecepty.cz/wp-content/uploads/2020/11/sousvide-hamburger.png", Name = "Hamburger", Description = "Juicy beef patty with lettuce, tomato, onion, and pickles on a sesame seed bun.", Price = 9.99 },
                new Food { Id = 3, ImageUrl = "https://media.istockphoto.com/id/688372776/photo/caesar-salad-on-white-background.jpg?s=612x612&w=0&k=20&c=kwaTRLVv5ANGZEhf86QH9t6_dYI_RVHfZ35dtFDECes=", Name = "Caesar Salad", Description = "Crisp romaine lettuce with Parmesan cheese, croutons, and creamy Caesar dressing.", Price = 8.99 },
                new Food { Id = 4, ImageUrl = "https://img.freepik.com/premium-photo/group-rolls-maki-isolated-white-background_185193-73954.jpg?w=2000", Name = "Sushi Roll", Description = "Fresh sushi roll with a variety of fish, vegetables, and sticky rice.", Price = 7.99 },
                new Food { Id = 5, ImageUrl = "https://img.freepik.com/premium-photo/stir-fry-chicken-with-vegetables-plate-isolated-white-background_123827-16364.jpg", Name = "Chicken Stir-Fry", Description = "Sautéed chicken with mixed vegetables and soy sauce served over steamed rice.", Price = 6.99 },
                new Food { Id = 6, ImageUrl = "https://cdn.britannica.com/34/206334-050-7637EB66/French-fries.jpg", Name = "French Fries", Description = "French fries that you can have with different sauces.", Price = 2.00 }
                );

            builder.Entity<Drink>().HasData(
                new Drink { Id = 1, ImageUrl = "https://d1ammsvb8n71kb.cloudfront.net/medias/sys_master/h21/hbc/8815442886686.jpg", Name = "Coca-Cola", Description = "Refreshing cola drink.", Price = 1.99 },
                new Drink { Id = 2, ImageUrl = "https://www.marthastewart.com/thmb/v-noUz0Pm9dexdEBhiOKiC-TKhk=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/oj-upgrade-103121806_horiz_0-83474c4f9a0b4d7e9c06fc989fa1f5d2.jpgitokHQdK4qxB", Name = "Orange Juice", Description = "Freshly squeezed orange juice.", Price = 2.49 },
                new Drink { Id = 3, ImageUrl = "https://s7d1.scene7.com/is/image/mcdonalds/DC_201906_1212_MediumIcedCoffee_Glass_A1_832x472:1-3-product-tile-desktop?wid=765&hei=472&dpr=off", Name = "Iced Coffee", Description = "Chilled coffee with milk and ice.", Price = 2.99 },
                new Drink { Id = 4, ImageUrl = "https://1er.cz/3523-large_default/freshly-squeezed-lemonade-250ml.jpg", Name = "Lemonade", Description = "Refreshing lemon-flavored drink.", Price = 1.49 },
                new Drink { Id = 5, ImageUrl = "https://cdn.myshoptet.com/usr/www.farmaufrantisky.cz/user/shop/big/2139_mojito.png?63c0024c", Name = "Mojito", Description = "Classic cocktail with rum, mint, lime, and soda.", Price = 5.99 },
                new Drink { Id = 6, ImageUrl = "https://www.chinamist.com/mm5/graphics/00000001/1/5300CM_TradBlack-LooseIced_24ct_730x616.jpg", Name = "Iced Tea", Description = "Chilled tea with a hint of lemon.", Price = 1.99 }
                );

        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}