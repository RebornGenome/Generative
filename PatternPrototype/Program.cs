﻿using FurnitureForPrototypeLibrary;
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
                factory = new HighTechFurnitureFactory();
                break;
            case "2":
                factory = new LoftFurnitureFactory();
                break;
            case "3":
                factory = new ClassicFurnitureFactory();
                break;
            default:
                Console.WriteLine("Вы ввели НЕдопустимое Значение!!! Повторите попытку.");
                return;
        }
        Client client = new Client(factory);
        client.CreateFurniture();

        if (factory is ICloneFurniture clonableFactory)
        {
            var clonedFactory = clonableFactory.Clone();
            Client clonedClient = new Client((IFurnitureFactory)clonedFactory);
            Console.WriteLine("Клонированная фабрика:");
            clonedClient.CreateFurniture();
        }
    }
}