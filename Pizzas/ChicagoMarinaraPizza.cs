using System;
using System.Xml.Linq;

namespace PizzaStore.Pizzas
{
	public class ChicagoMarinaraPizza : Pizza
	{
        public ChicagoMarinaraPizza()
        {
            name = "Chicago style pizza Marinara";
            dough = "Thick and fluffy dough";
            sause = "Marinara sause";
            toppings.Add("Parmeggiano");
        }
    }
}
