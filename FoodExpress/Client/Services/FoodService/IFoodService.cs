using FoodExpress.Shared;

namespace FoodExpress.Client.Services.FoodService
{
    public interface IFoodService
    {
        List<Food> Foods { get; set; }
        Task GetFoods();    
        Task<Food> GetFoodById(int id);
        Task<Food> AddFood(Food food);
    }
}
