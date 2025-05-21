using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Polymorphism4.Model
{
    public class Shape
    {
        private string shapeType;

        public Shape(string shapeType)
        {
            this.shapeType = shapeType.ToLower();
        }

        public double Volume(double radius = -1, double height = -1)
        {
            switch (shapeType)
            {
                case "cube":
                    double side = radius != -1 ? radius : 10;
                    return Math.Pow(side, 3);

                case "sphere":
                    if (radius == -1) radius = 10;
                    return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

                case "cylinder":
                    if (radius == -1) radius = 10;
                    if (height == -1) height = 10;
                    return Math.PI * Math.Pow(radius, 2) * height;

                case "cone":
                    if (radius == -1) radius = 10;
                    if (height == -1) height = 10;
                    return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;

                default:
                    throw new InvalidOperationException("Unsupported shape type.");
            }
        }
    }
}
