using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RootLogESin
{
    public static class SquareRootTests
    {
        public static void TestForFloat(float start, float end, float step)
        {
            Console.Write("Test MathSquareRoot for float:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                float i = start;
                for (; i < end; i += step)
                {
                    double resFloat = Math.Sqrt(i);
                }
            });
        }

        public static void TestForDouble(double start, double end, double step)
        {
            Console.Write("Test MathSquareRoot for double:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                double i = start;
                for (; i < end; i += step)
                {
                    double resDouble = Math.Sqrt(i);
                }
            });
        }

        public static void TestForDecimal(decimal start, decimal end, decimal step)
        {
            Console.Write("Test MathSquareRoot for decimal:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                decimal i = start;
                for (; i < end; i += step)
                {
                    double resDecimal = Math.Sqrt((double)i);
                }
            });
        }
    }
}
