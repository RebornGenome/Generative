using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternAbstractFactory.Furniture;

namespace PatternAbstractFactory.Factories
{
    public interface IFurnitureFactory
    {
        IBed CreateBed();
        ITable CreateTable();
        ICloset CreateCloset();
    }
}
