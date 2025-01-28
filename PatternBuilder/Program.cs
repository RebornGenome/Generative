using PatternBuilder;
using PatternBuilder.Builder;
using PatternBuilder.Builders;
using PatternBuilder.Director;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите тип приготовляемой Пиццы: 1 -> Вегетарианская Пицца, 2 -> Пицца 4 Сыра, 3 -> Классическая Пицца (Сицилиана)");
        Console.Write("Выбор: ");
        string choice = Console.ReadLine().Trim();
        IPizzaBuilder pizzaBuilder;
        IPizza pizzaReady = null;
        object director;
        switch (choice)
        {
            case "1":
                pizzaBuilder = new VegetarianPizzaBuilder();
                director = new VegetarianPizzaDirector(pizzaBuilder, pizzaReady);
                break;
            case "2":
                pizzaBuilder = new CheesePizzaBuilder();
                director = new CheesePizzaDirector(pizzaBuilder, pizzaReady);
                break;
            case "3":
                pizzaBuilder = new ClassicPizzaBuilder();
                director = new ClassicPizzaDirector(pizzaBuilder, pizzaReady);
                break;
            default:
                Console.WriteLine("Вы ввели НЕсуществующий номер для  приготовления Пиццы!!! Повторите попытку");
                return;
        }
        dynamic dynamicDirector = director;
        dynamicDirector.BuildPizza();
        Pizza pizza = dynamicDirector.GetPizza();
        pizza.Info();
    }
}