using FoodExpress.Shared;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace FoodExpress.Client.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly HttpClient _http;

        public CartService(HttpClient http)
        {
            _http = http;
        }

        public List<Order> Orders { get; set ; } = new List<Order>();

        public async Task CleanCart()
        {
            await _http.DeleteAsync($"api/Cart");
        }

        public async Task DeleteOrder(int orderId)
        {
            await _http.DeleteAsync($"api/Cart/{orderId}");
        }

        public async Task LoadOrders()
        {
            Orders = await _http.GetFromJsonAsync<List<Order>>("api/Cart");
        }
    }
}
