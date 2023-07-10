using FoodExpress.Server.Data;
using FoodExpress.Shared;
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

        [HttpGet]
        public async Task<List<Food>> GetFoods()
        {
            return await _context.Foods.ToListAsync();
        }
    }
}
