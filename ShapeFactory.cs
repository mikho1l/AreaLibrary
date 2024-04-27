using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLibrary
{
    public static class ShapeFactory
    {
        public enum ShapeType
        {
            Circle,
            Triangle
        }
        public static IAreable CreateShape(double[] parameters, ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    if(parameters.Length != 1)
                    {
                        throw new ArgumentException("Circle should have 1 parameter");
                    }
                    return new Circle(parameters[0]);
                case ShapeType.Triangle:
                    if(parameters.Length != 3)
                    {
                        throw new ArgumentException("Triangle should have 3 parameters");
                    }
                return new Triangle(parameters[0], parameters[1], parameters[2]);
                default:
                    throw new ArgumentException("Incorrect shape type");
            }
        }
    }
}
