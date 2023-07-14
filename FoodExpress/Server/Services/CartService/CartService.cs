using FoodExpress.Server.Data;
using FoodExpress.Shared;
using Microsoft.EntityFrameworkCore;

namespace FoodExpress.Server.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ApplicationDbContext _context;

        public CartService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
