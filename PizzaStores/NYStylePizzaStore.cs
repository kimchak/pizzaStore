using PizzaStore.Pizzas;

namespace PizzaStore
{
	public class NYStylePizzaStore : PizzaStore
	{
        public NYStylePizzaStore()
        {
        }

        protected override Pizza createPizza(String type)
        {
            if (type.ToLower() == "pepperoni")
            {
                return new NyPepperoniPizza();
            };
            if (type.ToLower() == "marinara")
            {
                return new NyMarinaraPizza();
            }
            throw new ApplicationException(string.Format("Non-existent pizza type", type));

        }
    }
}