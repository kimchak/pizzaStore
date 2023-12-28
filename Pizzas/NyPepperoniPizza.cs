using System;
namespace PizzaStore.Pizzas
{
    public class NyPepperoniPizza : Pizza
    {
        NyPepperoniPizza()
        
            {
                name = "New York style pizza Pepperoni";
                dough = "Thin Crust dough";
            sause = "Tomato sause";
                toppings.Add("Pepperoni");
            }
        
        public override string ToString()
        {
            return "NYC-style Pepperoni pizza";
        }
    }
}

