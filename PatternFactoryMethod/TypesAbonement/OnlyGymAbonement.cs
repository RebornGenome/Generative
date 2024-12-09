using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryMethod.TypesAbonement
{
    public class OnlyGymAbonement : IAbonement
    {
        public string GetTypeAbonement()
        {
            return "Только Зал";
        }

        public string GetDescription()
        {
            return "В данный Абонемент входит -> Посещение только " +
                "Тренажерного Зала (без каких либо дополнений)";
        }

        public double GetPrice()
        {
            return 225;
        }
    }
}
