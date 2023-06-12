using PizzaApp.Models;

namespace PizzaApp.Data
{
    public static class StaticDB
    {
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza(){ Id = 1, Name = "Capri", Price = 12.99, IsOnPromotion = true },
            new Pizza(){ Id = 2, Name = "Peperoni", Price = 11.99, IsOnPromotion = false }
        };
        public static List<Order> Orders = new List<Order>()
        {
            new Order(1, "John Doe", new List<Pizza>(){ Pizzas[0] }),
            new Order(2, "Bob Bobski", new List<Pizza>() { Pizzas[0], Pizzas[1] })
        };
    }
}
