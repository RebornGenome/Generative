using PatternBuilder.Builder;
using PatternBuilder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder.Director
{
    public class VegetarianPizzaDirector
    {
        private IPizzaBuilder _builderPizza;
        private IPizza _pizza;

        public VegetarianPizzaDirector(IPizzaBuilder pizzaBuilder, IPizza pizza)
        {
            _builderPizza = pizzaBuilder;
            _pizza = pizza;
        }

        public void BuildPizza()
        {
            _builderPizza.Name();
            _builderPizza.Dough();
            _builderPizza.AddCheese();
            _builderPizza.AddVegetables();
            _builderPizza.AddSauces();
        }

        public Pizza GetPizza()
        {
            if (_builderPizza is VegetarianPizzaBuilder builder)
            {
                return builder.GetPizza();
            }
            throw new InvalidOperationException("Неверный тип строителя");
        }
    }
}
