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
    }
}
