# Factory pattern implementation in C#

This is an example of Factory pattern in form of a pizza factory 🍕.  It contains a few pizza classes and pizzaStore classes which contain a factory method (`createPizza(type)`) that create pizzas for relevant stores. All pizzas inherit order() method from parent Pizza class. Stores are responsible for creating pizzas, that are specific to their needs - that's why the logic for their creation is handled by the factory method withing the PizzaStore class.

## Use cases
- As a NY pizza store worker I want to order a pizza with one simple action

- As a Chicago pizza store worker that just transfered from NY I want to order a Chicago-style just the way I used to do it in NY.

## How to use
First, create a pizza store, then use that store to create a pizza that is specifc to that store. I.e. a New York Style pizza store will create a New York-style pizza marinara, while Chicago Style Pizza Store will create a marinara, but in Chicago style, i.e. on thick dough.

```
NYStylePizzaStore nycStore = new NYStylePizzaStore();
nycStore.orderPizza("marinara");
```

## How to run
Use the provided classes in your own programme or simply run Program.cs to see how it behaves