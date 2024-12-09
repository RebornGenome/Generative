using PatternFactoryMethod.Factories;
using PatternFactoryMethod.TypesAbonement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryMethod
{
    public class Client
    {
        private readonly IAbonement _abonement;

        public Client(AbonementFactory factory)
        {
            _abonement = factory.CreateAbonement();
        }

        public void AbonementDetails()
        {
            Console.WriteLine($"Вы выбрали: {_abonement.GetTypeAbonement()}");
            Console.WriteLine($"Описание: {_abonement.GetDescription()}");
            Console.WriteLine($"Цена: {_abonement.GetPrice()}");
        }
    }
}
