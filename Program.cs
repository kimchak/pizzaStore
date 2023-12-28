// See https://aka.ms/new-console-template for more information
using PizzaStore;

Console.WriteLine("Hello, Pizza World!");
//PizzaFactory factory = new PizzaFactory();
//Pizza pizza1 = factory.createPizza("Pepperoni");
//Pizza pizza2 = factory.createPizza("marinara");

//Console.WriteLine(pizza1.ToString());
//Console.WriteLine(pizza2.ToString());

NYStylePizzaStore nycStore = new NYStylePizzaStore(new PizzaFactory());
nycStore.orderPizza("marinara");

ChicagoStylePizzaStore chicagoStore = new ChicagoStylePizzaStore(new PizzaFactory());
chicagoStore.orderPizza("marinara");

