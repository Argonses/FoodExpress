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

        public async Task<Drink> AddDrink(Drink drink)
        {
            if (drink == null)
            {
                return null;
            }

            await _context.Drinks.AddAsync(drink);
            await _context.SaveChangesAsync();
            return drink;
        }

        public async Task<Drink> GetDrinkById(int id)
        {
            var result = await _context.Drinks.FindAsync(id);
            if (result == null)
            {
                return null;
            }

            return result;
        }

        public async Task<List<Drink>> GetDrinks()
        {
            return await _context.Drinks.ToListAsync();
        }
    }
}
