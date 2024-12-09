using PatternFactoryMethod;
using PatternFactoryMethod.Factories;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите тип Абонемента:");
        Console.WriteLine("1 - Только Зал, 2 - Зал + Бассейн, 3 - Персональные Тренировки в Зале, " +
            "4 - Персональные Тренировки в Зале и в Бассейне, 5 - Студент");
        Console.Write("Выбор: ");
        string choice = Console.ReadLine().Trim();
        Console.WriteLine();
        AbonementFactory factory;
        switch (choice)
        {
            case "1":
                factory = new OnlyGymAbonementFactory();
                break;
            case "2":
                factory = new GymPoolAbonementFactory();
                break;
            case "3":
                factory = new GymPersonalTrainingFactory();
                break;
            case "4":
                factory = new GymPoolPersonalTrainingFactory();
                break;

            case "5":
                Console.WriteLine();
                Console.WriteLine("Выберите тип Студенчиского Абонемента:");
                Console.WriteLine("1 - Только Зал, 2 - Зал + Бассейн, 3 - Персональные Тренировки в Зале, " +
            "4 - Персональные Тренировки в Зале и в Бассейне");
                Console.Write("Выбор: ");
                string studentChoice = Console.ReadLine().Trim();
                switch (studentChoice)
                {
                    case "1":
                        factory = new StudentAbonementsFactory(new OnlyGymAbonementFactory());
                        break;
                    case "2":
                        factory = new StudentAbonementsFactory(new GymPoolAbonementFactory());
                        break;
                    case "3":
                        factory = new StudentAbonementsFactory(new GymPersonalTrainingFactory());
                        break;
                    case "4":
                        factory = new StudentAbonementsFactory(new GymPoolPersonalTrainingFactory());
                        break;
                    default:
                        Console.WriteLine("Вы ввели НЕсуществующий номер Абонемента!!! Повторите попытку.");
                        return;
                }
                break;
            default:
                Console.WriteLine("Вы ввели НЕсуществующий номер Абонемента!!! Повторите попытку.");
                return;
        }
        Client client = new Client(factory);
        client.AbonementDetails();
    }
}