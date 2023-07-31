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
            try
            {
                if (food == null)
                {
                    return null;
                }

                await _context.Foods.AddAsync(food);
                await _context.SaveChangesAsync();
                return food;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while adding the food.", ex);
            }
        }

        public async Task<Food> DeleteFood(int id)
        {
            try
            {
                var result = await _context.Foods.FindAsync(id);
                if (result == null)
                {
                    return null;
                }

                _context.Foods.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while deleting the food.", ex);
            }
        }

        public async Task<Food> GetFoodById(int id)
        {
            try
            {
                var result = await _context.Foods.FindAsync(id);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while retrieving the food.", ex);
            }
        }

        public async Task<List<Food>> GetFoods()
        {
            try
            {
                return await _context.Foods.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while retrieving the foods.", ex);
            }
        }
    }

}
