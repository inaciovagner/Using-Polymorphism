using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Polygon> polygons = new List<Polygon> ();
            polygons.Add(new Polygon());
            polygons.Add(new Rectangle());
            polygons.Add(new Triangle());

            foreach (Polygon p in polygons)
            {
              p.Draw();
            }
        }
    }
}