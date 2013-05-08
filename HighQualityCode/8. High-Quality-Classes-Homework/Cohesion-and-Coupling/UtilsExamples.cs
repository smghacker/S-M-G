using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileNameUtils.GetFileExtension("example"));
            Console.WriteLine(FileNameUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameUtils.GetFileExtension("example.new.pdf"));
                              
            Console.WriteLine(FileNameUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                GeometryUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                GeometryUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            FigureIn3D cube = new FigureIn3D(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", cube.CalcVolume());

            double cubeWidth = cube.Width;
            double cubeHeight = cube.Height;
            double cubeDepth = cube.Depth;
            Console.WriteLine("Diagonal XYZ = {0:f2}", GeometryUtils.CalcDiagonalXYZ(cubeWidth, cubeHeight,cubeDepth));
            Console.WriteLine("Diagonal XY = {0:f2}", GeometryUtils.CalcDiagonalXY(cubeWidth, cubeHeight));
            Console.WriteLine("Diagonal XZ = {0:f2}", GeometryUtils.CalcDiagonalXZ(cubeWidth,cubeDepth));
            Console.WriteLine("Diagonal YZ = {0:f2}", GeometryUtils.CalcDiagonalYZ(cubeHeight,cubeDepth));
        }
    }
}
