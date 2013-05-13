using System;

namespace Matrix
{
   public class MatrixDemo
    {
        public static void Main()
        {
            int dimension = 0;
            try
            {
                dimension = CheckAndGetInputForDimension(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            SpecialMatrix matrix = new SpecialMatrix(dimension);
            matrix.FillMatrix();
            matrix.Print();
        }

        public static int CheckAndGetInputForDimension(string input)
        {
            int dimension = 0;
            if (!int.TryParse(input, out dimension))
            {
                throw new FormatException("The input should be number, not string.");
            }
            else
            {
                if (dimension < 0 || dimension > 100)
                {
                    throw new ArgumentOutOfRangeException("dimension", "Dimension must be between 0 and 100");
                }
            }
            return dimension;
        }
    }
}
