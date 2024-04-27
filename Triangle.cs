using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public class Triangle : IAreable
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if(firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("All the sides of Triangle must be more than zero.");
            }
            if(!Exists(firstSide, secondSide, thirdSide))
            {
                throw new ArgumentException($"There is no Triangle with sides {firstSide} {secondSide} {thirdSide}");
            }
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
        private static bool Exists(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide || secondSide + thirdSide <= firstSide)
                return false;
            return true;
        }
        public double GetArea()
        {
            double semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        }
        public bool IsRightAngled()
        { 
            var sides = new double[] { FirstSide, SecondSide, ThirdSide };
            Array.Sort(sides);
            return (sides[0] * sides[0]) + (sides[1] * sides[1]) == (sides[2] * sides[2]);
        }
    }
}
