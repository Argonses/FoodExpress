using FoodExpress.Server.Data;
using FoodExpress.Server.Services.FoodService;
using FoodExpress.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodExpress.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _service;

        public FoodController(IFoodService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Food>> GetFoods()
        {
            return await _service.GetFoods();
        }

        [HttpGet("{id}")]
        public async Task<Food> GetFood(int id)
        {
            return await _service.GetFoodById(id);
        }
    }
}
