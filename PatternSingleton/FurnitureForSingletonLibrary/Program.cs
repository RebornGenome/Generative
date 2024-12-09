using PatternAbstractFactory;
using PatternAbstractFactory.Factories;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите Тип создаваемой Мебели: 1 - Хай-Тек, 2 - Лофт, 3 - Классик");
        string choice = Console.ReadLine().Trim();
        IFurnitureFactory factory;
        switch (choice)
        {
            case "1":
                factory = HighTechFurnitureFactory.Instance;
                break;
            case "2":
                factory = LoftFurnitureFactory.Instance;
                break;
            case "3":
                factory = ClassicFurnitureFactory.Instance;
                break;
            default:
                Console.WriteLine("Вы ввели НЕдопустимое Значение!!! Повторите попытку.");
                return;
        }
        Client client = new Client(factory);
        client.CreateFurniture();
    }
}