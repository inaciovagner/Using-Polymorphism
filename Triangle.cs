﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polymorphism
{
    class Triangle : Polygon
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing: Triangle");
        }
    }
}