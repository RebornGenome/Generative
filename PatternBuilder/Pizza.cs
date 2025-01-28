using PatternBuilder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternBuilder
{
    public class Pizza
    {
        public string Name { get; set; }
        
        public List<string> Ingredients { get; set; } = new List<string>();

        public void Info()
        {
            Console.WriteLine("__________________________________________________");
            Console.WriteLine($"Приготовлена -> {Name}");
            Console.WriteLine("__________________________________________________");
            Console.WriteLine($"Ее Ингредиенты: \n{string.Join("\n", Ingredients)}");
            Console.WriteLine("__________________________________________________");
            
        }
    }
}