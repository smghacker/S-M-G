using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    public class FigureIn3D
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public double Depth { get; private set; }

        public FigureIn3D(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public static double CalcDiagonalXYZ(double x, double y, double z)
        {
            double distance = GeometryUtils.CalcDistance3D(0, 0, 0, x, y, z);
            return distance;
        }

        public static double CalcDiagonalXY(double x, double y)
        {
            double distance = GeometryUtils.CalcDistance2D(0, 0, x, y);
            return distance;
        }

        public static double CalcDiagonalXZ(double x, double z)
        {
            double distance = GeometryUtils.CalcDistance2D(0, 0, x, z);
            return distance;
        }

        public static double CalcDiagonalYZ(double y, double z)
        {
            double distance = GeometryUtils.CalcDistance2D(0, 0, y, z);
            return distance;
        }
    }
}
