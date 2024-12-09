using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryMethod.TypesAbonement
{
    public class GymPoolAbonement : IAbonement
    {
        public string GetTypeAbonement()
        {
            return "Зал (плюс Бассейн)";
        }

        public string GetDescription()
        {
            return "В данный Абонемент входит -> Посещение " +
                "Тренажерного Зала (дополение -> Абонемент в Бассейн)";
        }

        public double GetPrice()
        {
            return 330;
        }
    }
}
