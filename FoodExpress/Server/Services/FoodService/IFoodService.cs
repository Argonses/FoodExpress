using FoodExpress.Shared;

namespace FoodExpress.Server.Services.FoodService
{
    public interface IFoodService
    {
        Task<List<Food>> GetFoods();
    }
}
