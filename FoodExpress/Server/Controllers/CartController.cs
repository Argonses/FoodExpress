using FoodExpress.Server.Services.CartService;
using FoodExpress.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodExpress.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _service;

        public CartController(ICartService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Order>> GetOrders()
        {
            return await _service.GetOrders();
        }

        [HttpPost]
        public async Task<Order> AddOrder(Order order)
        {
            return await _service.AddOrder(order);
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteOrder(int id)
        {
            return await _service.DeleteOrder(id);
        }
    }
}
