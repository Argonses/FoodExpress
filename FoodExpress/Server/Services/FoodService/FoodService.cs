using FoodExpress.Server.Data;
using FoodExpress.Shared;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodExpress.Server.Services.FoodService
{
    public class FoodService : IFoodService
    {
        private readonly ApplicationDbContext _context;

        public FoodService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Food> AddFood(Food food)
        {
            if (food == null)
            {
                return null;
            }

            await _context.Foods.AddAsync(food);
            await _context.SaveChangesAsync();
            return food;
        }

        public async Task<Food> DeleteFood(int id)
        {
            var result = await _context.Foods.FindAsync(id);
            if (result == null)
            {
                return null;
            }

            _context.Foods.Remove(result);
            _context.SaveChanges();
            return result;
        }

        public async Task<Food> GetFoodById(int id)
        {
            var result = await _context.Foods.FindAsync(id);
            if (result == null)
            {
                return null;
            }

            return result;
        }

        [HttpGet]
        public async Task<List<Food>> GetFoods()
        {
            return await _context.Foods.ToListAsync();
        }
    }
}
