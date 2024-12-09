using FurnitureForPrototypeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory.Furniture
{
    public interface ITable : IPrototype<ITable>
    {
        void Create();
    }
}
