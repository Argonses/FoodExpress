using FoodExpress.Server.Data;
using FoodExpress.Shared;
using Microsoft.EntityFrameworkCore;

namespace FoodExpress.Server.Services.DrinkService
{
    public class DrinkService : IDrinkService
    {
        private readonly ApplicationDbContext _context;

        public DrinkService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Drink>> GetDrinks()
        {
            return await _context.Drinks.ToListAsync();
        }
    }
}
