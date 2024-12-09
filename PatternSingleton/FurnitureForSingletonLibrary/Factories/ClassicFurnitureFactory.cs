using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternAbstractFactory.Furniture;

namespace PatternAbstractFactory.Factories
{
    public class ClassicFurnitureFactory : IFurnitureFactory
    {
        private static ClassicFurnitureFactory _instance;
        
        private ClassicFurnitureFactory() { }

        public static ClassicFurnitureFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClassicFurnitureFactory();
                }
                return _instance;
            }
        }

        public IBed CreateBed()
        {
            return new ClassicBed();
        }

        public ITable CreateTable()
        {
            return new ClassicTable();
        }

        public ICloset CreateCloset()
        {
            return new ClassicCloset();
        }
    }
}
