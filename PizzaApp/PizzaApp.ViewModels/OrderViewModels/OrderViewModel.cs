using PizzaApp.Domain.Models;

namespace PizzaApp.ViewModels.OrderViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string UserFullName { get; set; }
        public string Address { get; set; }
        public List<PizzaOrder> Pizzas { get; set; }
    }
}
