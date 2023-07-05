using PizzaApp.Domain.Enums;

namespace PizzaApp.ViewModels.OrderViewModels
{
    public class OrderCreateViewModel
    {
        public int UserId { get; set; }
        public string Location { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }
        public List<int> PizzaIds { get; set; }
    }
}
