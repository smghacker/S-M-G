using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Size_refactor
{
    class RefactorSize
    {
        public class Point
        {
            private double width;
            private double height;

            public Point(double width, double height)
            {
                this.Width = width;
                this.Height = height;
            }

            public double Height
            {
                get { return height; }
                set { height = value; }
            }

            public double Width
            {
                get { return width; }
                set { width = value; }
            }
        }

        public static Point GetRotatedPoint(Point size, double angleOfRotation)
        {


            double cosWidthSize = Math.Abs(Math.Cos(angleOfRotation)) * size.Width;
            double sinHeightSize = Math.Abs(Math.Sin(angleOfRotation)) * size.Height;
            double resultWidthSize = cosWidthSize + sinHeightSize;

            double cosHeightSize = Math.Abs(Math.Cos(angleOfRotation)) * size.Height;
            double sinWidthSize = Math.Abs(Math.Sin(angleOfRotation)) * size.Width;
            double resultHeightSize = cosHeightSize + sinWidthSize;

            Point result = new Point(resultWidthSize, resultHeightSize);

            return result;
        }

    }
}
