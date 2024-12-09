using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternAbstractFactory.Factories;
using PatternAbstractFactory.Furniture;

namespace PatternAbstractFactory
{
    public class Client
    {
        private readonly IBed _bed;
        private readonly ITable _table;
        private readonly ICloset _closet;

        public Client(IFurnitureFactory factory)
        {
            _bed = factory.CreateBed();
            _table = factory.CreateTable();
            _closet = factory.CreateCloset();
        }

        public void CreateFurniture()
        {
            _bed.Create();
            _table.Create();
            _closet.Create();
        }

        public void CloneFurniture()
        {
            var cloneBed = _bed.Clone();
            var cloneTable = _table.Clone();
            var cloneCloset = _closet.Clone();

            Console.WriteLine("\nБыли сделаны -> Копии Мебели:");
            cloneBed.Create();
            cloneTable.Create();
            cloneCloset.Create();
        }
    }
}
