using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryMethod.TypesAbonement
{
    public class GymPersonalTraining : IAbonement
    {
        public string GetTypeAbonement()
        {
            return "Зал (Персональные Тренировки)";
        }

        public string GetDescription()
        {
            return "В данный Абонемент входит -> Посещение только " +
                "Тренажерного Зала (дополение -> Персональные Тренировки с Квалифицированным Тренером)";
        }

        public double GetPrice()
        {
            return 300;
        }
    }
}
