using PatternBuilder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder.Director
{
    public class VegetarianPizzaDirector
    {
        private IPizzaBuilder _pizzaBuilder;

        public VegetarianPizzaDirector(IPizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void BuildPizza()
        {
            _pizzaBuilder.Name();
            _pizzaBuilder.Dough();
            _pizzaBuilder.AddCheese();
            _pizzaBuilder.AddVegetables();
            _pizzaBuilder.AddSauces();
        }

        public Pizza GetPizza()
        {
            return _pizzaBuilder.GetPizza();
        }
    }
}
