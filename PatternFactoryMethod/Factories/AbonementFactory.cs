using PatternFactoryMethod.TypesAbonement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryMethod.Factories
{
    public abstract class AbonementFactory
    {
        public abstract IAbonement CreateAbonement();
    }
}
