using System;

namespace Abstraction
{
    class Circle : IFigure
    {
        private double radius = 0.0;

        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public Circle(double radius)
        {
            if (radius > 0)
            {
                this.Radius = radius;
            }
            else
            {
                throw new ArgumentException("Radius should be positive number non equal to 0");
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
