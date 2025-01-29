using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureForPrototypeLibrary;
using PatternAbstractFactory.Furniture;

namespace PatternAbstractFactory.Factories
{
    public class ClassicFurnitureFactory : IFurnitureFactory, ICloneFurniture
    {
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

        public ICloneFurniture Clone()
        {
            return (ICloneFurniture)this.MemberwiseClone();
        }
    }
}
