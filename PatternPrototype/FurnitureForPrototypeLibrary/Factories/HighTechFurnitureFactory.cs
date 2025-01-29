using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureForPrototypeLibrary;
using PatternAbstractFactory.Furniture;

namespace PatternAbstractFactory.Factories
{
    public class HighTechFurnitureFactory : IFurnitureFactory, ICloneFurniture
    {
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

        public ICloneFurniture Clone()
        {
            return (ICloneFurniture)this.MemberwiseClone();
        }
    }
}
