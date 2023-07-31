using FoodExpress.Server.Data;
using FoodExpress.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static NuGet.Packaging.PackagingConstants;

namespace FoodExpress.Server.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly ApplicationDbContext _context;

        public CartService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Order> AddOrder(Order order)
        {
            try
            {
                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();
                return order;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while adding the order.", ex);
            }
        }

        public async Task<IActionResult> CleanCart()
        {
            try
            {
                var orders = await _context.Orders.ToListAsync();
                _context.Orders.RemoveRange(orders);
                await _context.SaveChangesAsync();
                return new OkResult();
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while cleaning the cart.", ex);
            }
        }

        public async Task<bool> DeleteOrder(int orderId)
        {
            try
            {
                var order = await _context.Orders.FindAsync(orderId);
                if (order != null)
                {
                    _context.Orders.Remove(order);
                    await _context.SaveChangesAsync();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while deleting the order.", ex);
            }
        }

        public async Task<List<Order>> GetOrders()
        {
            try
            {
                return await _context.Orders.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong while retrieving the orders.", ex);
            }
        }
    }

}
