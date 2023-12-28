using System;
namespace PizzaStore
{
	public abstract class PizzaStore
	{
        protected abstract Pizza createPizza(string type);

        public Pizza orderPizza(string type)
		{
			Pizza pizza;
			pizza = this.createPizza(type);
            Console.WriteLine(pizza.ToString());
            pizza.prepare();
			pizza.bake();
			pizza.cut();
			pizza.box();
			
			return pizza;
		}


	}
}

