using PatternBuilder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PatternBuilder.Builder
{
    public class CheesePizzaBuilder : IPizzaBuilder, IPizza
    {
        private Pizza pizza = new Pizza();

        public void Name()
        {
            pizza.Name = "Пицца 4 Сыра";
        }

        public void Dough()
        {
            pizza.Ingredients.Add("Тесто");
        }

        public void AddCheese()
        {
            pizza.Ingredients.Add("Сыр Моцарелла");
            pizza.Ingredients.Add("Сыр Пармезан");
            pizza.Ingredients.Add("Сыр Дор Блю");
            pizza.Ingredients.Add("Сыр Эдам");
        }

        public void AddVegetables()
        {
            pizza.Ingredients.Add("Зелень");
        }

        public void AddSauces()
        {
            pizza.Ingredients.Add("Сырный Соус");
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
