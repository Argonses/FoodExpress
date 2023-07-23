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

        public async Task<Drink> AddDrink(Drink drink)
        {
            var result = await _http.PostAsJsonAsync<Drink>("api/Drink", drink);
            return drink;
        }

        public async Task<Drink> DeleteDrink(int id)
        {
            var response = await _http.DeleteAsync($"api/Drink/{id}");
            var deletedDrink = await response.Content.ReadFromJsonAsync<Drink>();
            return deletedDrink;
        }

        public async Task<Drink> GetDrinkById(int id)
        {
            var result = await _http.GetFromJsonAsync<Drink>($"api/Drink/{id}");
            return result;
        }

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
