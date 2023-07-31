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
            try
            {
                if (drink == null)
                {
                    return null;
                }

                await _context.Drinks.AddAsync(drink);
                await _context.SaveChangesAsync();
                return drink;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while adding the drink.", ex);
            }
        }

        public async Task<Drink> DeleteDrink(int id)
        {
            try
            {
                var result = await _context.Drinks.FindAsync(id);
                if (result == null)
                {
                    return null;
                }

                _context.Drinks.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while deleting the drink.", ex);
            }
        }

        public async Task<Drink> GetDrinkById(int id)
        {
            try
            {
                var result = await _context.Drinks.FindAsync(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while retrieving the drink.", ex);
            }
        }

        public async Task<List<Drink>> GetDrinks()
        {
            try
            {
                return await _context.Drinks.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while retrieving the drinks.", ex);
            }
        }
    }
}
