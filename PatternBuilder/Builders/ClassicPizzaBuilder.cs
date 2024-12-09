using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder.Builder
{
    public class ClassicPizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public void Name()
        {
            pizza.Name = "Классическая Пицца (Сицилиана)";
        }

        public void Dough()
        {
            pizza.Ingredients.Add("Тесто");
        }

        public void AddCheese()
        {
            pizza.Ingredients.Add("Сыр Моцарелла");
        }

        public void AddVegetables()
        {
            pizza.Ingredients.Add("Маслины");
            pizza.Ingredients.Add("Помидоры");
            pizza.Ingredients.Add("Грибы");
            pizza.Ingredients.Add("Зелень");
        }

        public void AddSauces()
        {
            pizza.Ingredients.Add("Томатный Соус");
        }

        public void AddMeat()
        {
            pizza.Ingredients.Add("Ветчина");
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
