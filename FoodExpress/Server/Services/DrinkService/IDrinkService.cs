using FoodExpress.Shared;

namespace FoodExpress.Server.Services.DrinkService
{
    public interface IDrinkService
    {
        Task<List<Drink>> GetDrinks();
        Task<Drink> GetDrinkById(int id);
        Task<Drink> AddDrink(Drink drink);
    }
}
