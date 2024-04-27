using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Circle : IAreable
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentException("The radius of Circle must be more then zero");
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
