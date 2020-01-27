﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public interface IShape
    {
        string Name { get; set; }

        void GetShapeName();
    }
}