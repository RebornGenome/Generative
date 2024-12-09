using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory.Furniture
{
    public class HighTechBed : IBed
    {
        public void Create()
        {
            Console.WriteLine("Кровать была создана в Стиле - Хай-Тек");
        }
    }

    public class HighTechTable : ITable
    {
        public void Create()
        {
            Console.WriteLine("Стол был создан в Стиле - Хай-Тек");
        }
    }

    public class HighTechCloset : ICloset
    {
        public void Create()
        {
            Console.WriteLine("Шкаф был создан в Стиле - Хай-Тек");
        }
    }
}
