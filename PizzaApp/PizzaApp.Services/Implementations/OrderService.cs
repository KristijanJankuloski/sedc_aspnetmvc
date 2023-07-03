using PizzaApp.DataAccess.Repositories.Interfaces;
using PizzaApp.Domain.Models;
using PizzaApp.Services.Interfaces;
using PizzaApp.ViewModels.OrderViewModels;

namespace PizzaApp.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task CreateOrder(OrderViewModel order)
        {
            throw new NotImplementedException();
        }
    }
}
