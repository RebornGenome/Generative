using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder.Builder
{
    public class VegetarianPizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public void Name()
        {
            pizza.Name = "Вегетарианская Пицца";
        }

        public void Dough()
        {
            pizza.Ingredients.Add("Тесто");
        }

        public void AddCheese()
        {
            pizza.Ingredients.Add("Сыр Буко");
        }

        public void AddVegetables()
        {
            pizza.Ingredients.Add("Помидоры");
            pizza.Ingredients.Add("Зелень");
            pizza.Ingredients.Add("Грибы");
            pizza.Ingredients.Add("Запеченные Овощи");
        }

        public void AddSauces()
        {
            pizza.Ingredients.Add("Соусы");
        }

        public void AddMeat()
        {

        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
