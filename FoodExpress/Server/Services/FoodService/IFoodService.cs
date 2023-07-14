using FoodExpress.Shared;

namespace FoodExpress.Server.Services.FoodService
{
    public interface IFoodService
    {
        Task<List<Food>> GetFoods();
        Task<Food> GetFoodById(int id);
        Task<Food> AddFood(Food food);
        Task<Food> DeleteFood(int id);
    }
}
