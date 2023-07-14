using FoodExpress.Server.Services.DrinkService;
using FoodExpress.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodExpress.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : ControllerBase
    {
        private readonly IDrinkService _service;

        public DrinkController(IDrinkService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Drink>> GetDrinks()
        {
            return await _service.GetDrinks();
        }

        [HttpGet("{id}")]
        public async Task<Drink> GetDrink(int id)
        {
            return await _service.GetDrinkById(id);
        }

        [HttpPost]
        public async Task<Drink> AddDrink(Drink drink)
        {
            return await _service.AddDrink(drink);
        }
    }
}
