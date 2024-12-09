using PatternFactoryMethod.TypesAbonement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryMethod.Factories
{
    public class StudentAbonementsFactory : AbonementFactory
    {
        private AbonementFactory _baseAbonements;

        public StudentAbonementsFactory(AbonementFactory baseFactory)
        {
            _baseAbonements = baseFactory;
        }

        public override IAbonement CreateAbonement()
        {
            return new StudentAbonements(_baseAbonements.CreateAbonement());
        }
    }
}
