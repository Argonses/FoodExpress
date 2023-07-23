using FoodExpress.Shared;

namespace FoodExpress.Client.Services.CartService
{
    public interface ICartService
    {
        List<Order> Orders { get; set; }
        Task LoadOrders();
        Task DeleteOrder(int orderId);
    }
}
