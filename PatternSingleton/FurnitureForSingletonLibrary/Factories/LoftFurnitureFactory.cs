using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternAbstractFactory.Furniture;

namespace PatternAbstractFactory.Factories
{
    public class LoftFurnitureFactory : IFurnitureFactory
    {
        private static LoftFurnitureFactory _instance;

        private LoftFurnitureFactory() { }

        public static LoftFurnitureFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoftFurnitureFactory();
                }
                return _instance;
            }
        }

        public IBed CreateBed()
        {
            return new LoftBed();
        }

        public ITable CreateTable()
        {
            return new LoftTable();
        }

        public ICloset CreateCloset()
        {
            return new LoftCloset();
        }
    }
}
