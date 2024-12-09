using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory.Furniture
{
    public class LoftBed : IBed
    {
        public void Create()
        {
            Console.WriteLine("Кровать была создана в Стиле - Лофт");
        }

        public IBed Clone()
        {
            return new LoftBed();
        }
    }

    public class LoftTable : ITable
    {
        public void Create()
        {
            Console.WriteLine("Стол был создан в Стиле - Лофт");
        }

        public ITable Clone()
        {
            return new LoftTable();
        }
    }

    public class LoftCloset : ICloset
    {
        public void Create()
        {
            Console.WriteLine("Шкаф был создан в Стиле - Лофт");
        }

        public ICloset Clone()
        {
            return new LoftCloset();
        }
    }
}
