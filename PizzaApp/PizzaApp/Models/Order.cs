namespace PizzaApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; } = string.Empty;
        public List<Pizza> Pizzas { get; set; }
        public Order()
        {
            Pizzas = new List<Pizza>();
        }
        public Order(int id, string customer, List<Pizza> pizzas)
        {
            Id = id;
            Customer = customer;
            Pizzas = pizzas;
        }

        public string PizzasString()
        {
            string p = string.Empty;
            foreach(var pizza in Pizzas)
            {
                p = $"{p}{pizza.Name}, ";
            }
            p = p.Substring(0, p.Length - 2);
            return p;
        }
    }
}
