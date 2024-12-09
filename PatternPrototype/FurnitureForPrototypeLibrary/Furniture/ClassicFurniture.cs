﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory.Furniture
{
    public class ClassicBed : IBed
    {
        public void Create()
        {
            Console.WriteLine("Кровать была создана в стиле - Классик");
        }

        public IBed Clone()
        {
            return new ClassicBed();
        }
    }

    public class ClassicTable : ITable
    {
        public void Create()
        {
            Console.WriteLine("Стол был создан в Стиле - Классик");
        }

        public ITable Clone()
        {
            return new ClassicTable();
        }
    }

    public class ClassicCloset : ICloset
    {
        public void Create()
        {
            Console.WriteLine("Шкаф был создан в Стиле - Классик");
        }

        public ICloset Clone()
        {
            return new ClassicCloset();
        }
    }
}