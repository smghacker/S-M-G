using System;

namespace Abstraction
{
    class Rectangle : IFigure
    {
        private double width = 0.0;
        private double height = 0.0;

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return height; }
            set { this.height = value; }
        }

        public Rectangle(double width, double height)
        {
            if (width > 0)
            {
                this.Width = width;
            }
            else
            {
                throw new ArgumentException("Width should be positive number not equal to 0");
            }
            if (height > 0)
            {
                this.Height = height;
            }
            else
            {
                throw new ArgumentException("Height should be positive number not equal to 0");
            }
        }

        public double CalcPerimeter()
        {
            double perimeter = 2 * (this.Height + this.Width);
            return perimeter;
        }

        public double CalcSurface()
        {
            return this.Height * this.Width;
        }
    }
}
