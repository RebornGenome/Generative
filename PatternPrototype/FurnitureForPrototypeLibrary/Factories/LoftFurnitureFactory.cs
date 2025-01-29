using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureForPrototypeLibrary;
using PatternAbstractFactory.Furniture;

namespace PatternAbstractFactory.Factories
{
    public class LoftFurnitureFactory : IFurnitureFactory, ICloneFurniture
    {
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

        public ICloneFurniture Clone()
        {
            return (ICloneFurniture)this.MemberwiseClone();
        }
    }
}
