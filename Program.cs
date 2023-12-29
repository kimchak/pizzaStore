// See https://aka.ms/new-console-template for more information
using PizzaStore;

Console.WriteLine("Hello, Pizza World!");

NYStylePizzaStore nycStore = new NYStylePizzaStore();
nycStore.orderPizza("marinara");

ChicagoStylePizzaStore chicagoStore = new ChicagoStylePizzaStore();
chicagoStore.orderPizza("marinara");

