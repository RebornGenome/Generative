using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryMethod.TypesAbonement
{
    public class GymPoolPersonalTraining : IAbonement
    {
        public string GetTypeAbonement()
        {
            return "Зал и Бассейн (Персональные Тренировки)";
        }

        public string GetDescription()
        {
            return "В данный Абонемент входит -> Посещение " +
                "Тренажерного Зала, Бассейна (дополение -> Персональные " +
                "Тренировки с Квалифицированными Тренерами)";
        }

        public double GetPrice()
        {
            return 400;
        }
    }
}
