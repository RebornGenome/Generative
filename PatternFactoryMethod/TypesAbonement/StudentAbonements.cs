using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryMethod.TypesAbonement
{
    public class StudentAbonements : IAbonement
    {
        private IAbonement _studentAbonement;

        public StudentAbonements(IAbonement abonement)
        {
            _studentAbonement = abonement;
        }

        public string GetTypeAbonement()
        {
            return _studentAbonement.GetTypeAbonement() + " -> Студенческий Абонемет";
        }

        public string GetDescription()
        {
            return _studentAbonement.GetDescription() + " и Скидка в 20%";
        }

        public double GetPrice()
        {
            return  _studentAbonement.GetPrice() * 0.8;
        }
    }
}
