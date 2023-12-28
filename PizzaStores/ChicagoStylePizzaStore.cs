using PizzaStore.Pizzas;

namespace PizzaStore
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public ChicagoStylePizzaStore()
        {
        }

        protected override Pizza createPizza(String type)
        {
            if (type.ToLower() == "pepperoni")
            {
                return new ChicagoPepperoniPizza();
            };
            if (type.ToLower() == "marinara")
            {
                return new ChicagoMarinaraPizza();
            }
            throw new ApplicationException(string.Format("Non-existent pizza type", type));

        }
    }
}