using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder.Builder
{
    public interface IPizzaBuilder
    {
        void Name();

        void Dough();

        void AddCheese();

        void AddVegetables();

        void AddSauces();

        void AddMeat();

        Pizza GetPizza();
    }
}
