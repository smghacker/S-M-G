using _03.RootLogESin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RootLogESin
{
    public static class NaturalLogarithmTests
    {
        public static void TestForFloat(float start, float end, float step)
        {
            Console.Write("Test NaturalLogarithm for float:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                float i = start;
                for (; i < end; i += step)
                {
                    double resFloat = Math.Log(i,Math.E);
                }
            });
        }

        public static void TestForDouble(double start, double end, double step)
        {
            Console.Write("Test NaturalLogarithm for double:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                double i = start;
                for (; i < end; i += step)
                {
                    double resDouble = Math.Log(i, Math.E);
                }
            });
        }

        public static void TestForDecimal(decimal start, decimal end, decimal step)
        {
            Console.Write("Test NaturalLogarithm for decimal:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                decimal i = start;
                for (; i < end; i += step)
                {
                    double resDecimal = Math.Log((double)i, Math.E);
                }
            });
        }
    }
}
