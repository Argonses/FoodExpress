using FoodExpress.Shared;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace FoodExpress.Client.Services.DrinkService
{
    public class DrinkService : IDrinkService
    {
        private readonly HttpClient _http;

        public DrinkService(HttpClient http)
        {
            _http = http;
        }

        public List<Drink> Drinks { get; set; } = new List<Drink>();

        public async Task GetDrinks()
        {
            var result = await _http.GetFromJsonAsync<List<Drink>>("api/Drink");
            if (result != null)
            {
                Drinks = result;
            }
        }
    }
}
