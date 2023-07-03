using PizzaApp.ViewModels.OrderViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaApp.Services.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrder(OrderViewModel order);
    }
}
