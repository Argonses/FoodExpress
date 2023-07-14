using FoodExpress.Shared;

namespace FoodExpress.Client.Services.DrinkService
{
    public interface IDrinkService
    {
        List<Drink> Drinks { get; set; }
        Task GetDrinks();
        Task<Drink> GetDrinkById(int id);
        Task<Drink> AddDrink(Drink drink);
    }
}
