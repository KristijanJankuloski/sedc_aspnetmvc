using PizzaApp.Domain.Models;
using PizzaApp.ViewModels.OrderViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Mappers
{
    public static class OrderMapper
    {
        public static Order ToOrder(this OrderCreateViewModel order)
        {
            Order createOrder = new Order
            {
                UserId = order.UserId,
                IsDelivered = false,
                Location = order.Location,
                PaymentMethod = order.PaymentMethod,
            };
            createOrder.PizzaOrders = new List<PizzaOrder>();
            return createOrder;
        }
    }
}
