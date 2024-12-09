﻿using FurnitureForPrototypeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAbstractFactory.Furniture
{
    public interface ICloset : IPrototype<ICloset>
    {
        void Create();
    }
}
