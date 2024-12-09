﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternAbstractFactory.Furniture;

namespace PatternAbstractFactory.Factories
{
    public class HighTechFurnitureFactory : IFurnitureFactory
    {
        private static HighTechFurnitureFactory _instance;

        private HighTechFurnitureFactory() { }

        public static HighTechFurnitureFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HighTechFurnitureFactory();
                }
                return _instance;
            }
        }

        public IBed CreateBed()
        {
            return new HighTechBed();
        }

        public ITable CreateTable()
        {
            return new HighTechTable();
        }

        public ICloset CreateCloset()
        {
            return new HighTechCloset();
        }
    }
}
