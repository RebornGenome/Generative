using PatternBuilder;
using PatternBuilder.Builder;
using PatternBuilder.Director;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите тип приготовляемой Пиццы: 1 -> Вегетарианская Пицца, 2 -> Пицца 4 Сыра, 3 -> Классическа Пицца (Сицилиана)");
        Console.Write("Выбор: ");
        string choice = Console.ReadLine().Trim();
        IPizzaBuilder pizzaBuilder;
        object director;
        switch (choice)
        {
            case "1":
                pizzaBuilder = new VegetarianPizzaBuilder();
                director = new VegetarianPizzaDirector(pizzaBuilder);
                break;
            case "2":
                pizzaBuilder = new CheesePizzaBuilder();
                director = new CheesePizzaDirector(pizzaBuilder);
                break;
            case "3":
                pizzaBuilder = new ClassicPizzaBuilder();
                director = new ClassicPizzaDirector(pizzaBuilder);
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