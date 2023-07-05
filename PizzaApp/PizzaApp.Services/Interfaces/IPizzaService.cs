namespace PizzaApp.Services.Interfaces
{
    using PizzaApp.ViewModels.PizzaViewModels;

    public interface IPizzaService
    {
        Task<List<PizzaListViewModel>> GetPizzasForCards();

        Task<PizzaDetailsViewModel> GetPizzaDetails(int id);
        Task<List<PizzaSelectListViewModel>> GetAllForSelectList();

        Task<int> DeletePizzaById(int id);

        Task CreatePizza(PizzaViewModel pizzaViewModel);

        Task<PizzaViewModel> GetPizzaForEditing(int id);

        Task EditPizza(PizzaViewModel pizzaViewModel);
    }
}
