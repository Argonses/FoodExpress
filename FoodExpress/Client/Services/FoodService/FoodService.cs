﻿using FoodExpress.Shared;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace FoodExpress.Client.Services.FoodService
{
    public class FoodService : IFoodService
    {
        private readonly HttpClient _http;

        public FoodService(HttpClient http)
        {
            _http = http;
        }

        public List<Food> Foods { get; set; } = new List<Food>();
         
        public async Task GetFoods()
        {
            var result = await _http.GetFromJsonAsync<List<Food>>("api/Food");
            if (result != null)
            {
                Foods = result;
            }
        }
    }
}
