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
                new Food { Id = 5, ImageUrl = "https://img.freepik.com/premium-photo/stir-fry-chicken-with-vegetables-plate-isolated-white-background_123827-16364.jpg", Name = "Chicken Stir-Fry", Description = "Sautéed chicken with mixed vegetables and soy sauce served over steamed rice.", Price = 6.99 }
                );
        }

        public DbSet<Food> Foods { get; set; }
    }
}