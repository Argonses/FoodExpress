using FoodExpress.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FoodExpress.Server.Services.CartService
{
    public interface ICartService
    {
        Task<List<Order>> GetOrders();
        Task<Order> AddOrder(Order order);
        Task<bool> DeleteOrder(int orderId);
        Task<IActionResult> CleanCart();
    }
}
