using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternFactoryMethod.TypesAbonement
{
    public interface IAbonement
    {
        string GetTypeAbonement();
        string GetDescription();
        double GetPrice();
    }
}
