using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RootLogESin
{
    public static class SinTests
    {
        public static void TestForFloat(float start, float end, float step)
        {
            Console.Write("Test Sin for float:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                float i = start;
                for (; i < end; i += step)
                {
                    double resFloat = Math.Sin(i / 180);
                }
            });
        }

        public static void TestForDouble(double start, double end, double step)
        {
            Console.Write("Test Sin for double:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                double i = start;
                for (; i < end; i += step)
                {
                    double resDouble = Math.Sin(i/180);
                }
            });
        }

        public static void TestForDecimal(decimal start, decimal end, decimal step)
        {
            Console.Write("Test Sin for decimal:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                decimal i = start;
                for (; i < end; i += step)
                {
                    double resDecimal = Math.Sin((double)i/180);
                }
            });
        }
    }
}
