using PatternBuilder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder.Director
{
    public class CheesePizzaDirector
    {
        private IPizzaBuilder _builderPizza;

        public CheesePizzaDirector(IPizzaBuilder pizzaBuilder)
        {
            _builderPizza = pizzaBuilder;
        }

        public void BuildPizza()
        {
            _builderPizza.Name();
            _builderPizza.Dough();
            _builderPizza.AddCheese();
            _builderPizza.AddVegetables();
            _builderPizza.AddSauces();
            _builderPizza.GetPizza();
        }

        public Pizza GetPizza()
        {
            return _builderPizza.GetPizza();
        }
    }
}
