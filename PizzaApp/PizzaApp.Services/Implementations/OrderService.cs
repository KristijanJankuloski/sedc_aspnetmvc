using PizzaApp.DataAccess.Repositories.Implementations;
using PizzaApp.DataAccess.Repositories.Interfaces;
using PizzaApp.Domain.Models;
using PizzaApp.Mappers;
using PizzaApp.Services.Interfaces;
using PizzaApp.ViewModels.OrderViewModels;

namespace PizzaApp.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;
        private readonly IRepository<User> _userRepository;
        public OrderService(IRepository<Order> orderRepository, IRepository<User> userReposiotry)
        {
            _orderRepository = orderRepository;
            _userRepository = userReposiotry;
        }

        public async Task CreateOrder(OrderCreateViewModel model)
        {
            Order order = await _orderRepository.InsertAndReturn(model.ToOrder());
            order.User = await _userRepository.GetById(model.UserId);
            foreach (int pizzaId in model.PizzaIds)
            {
                order.PizzaOrders.Add(new PizzaOrder
                {
                    PizzaId = pizzaId,
                    OrderId = order.Id,
                    Order = order
                });
            }
            await _orderRepository.Update(order);
        }
    }
}
