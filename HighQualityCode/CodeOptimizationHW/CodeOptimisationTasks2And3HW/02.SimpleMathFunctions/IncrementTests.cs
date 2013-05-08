using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SimpleMathFunctions
{
    public static class IncrementTests
    {
        public static void TestForInt(int start, int end, int step)
        {
            Console.Write("Test Increment for int:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                int i = start;
                for (; i < end; i++)
                {
                }
            });
        }

        public static void TestForLong(long start, long end, long step)
        {
            Console.Write("Test Increment for long:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                long i = start;
                for (; i < end; i++)
                {
                }
            });
        }

        public static void TestForFloat(float start, float end, float step)
        {
            Console.Write("Test Increment for float:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                float i = start;
                for (; i < end; i++)
                {
                }
            });
        }

        public static void TestForDouble(double start, double end, double step)
        {
            Console.Write("Test Increment for double:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                double i = start;
                for (; i < end; i++)
                {
                }
            });
        }

        public static void TestForDecimal(decimal start, decimal end, decimal step)
        {
            Console.Write("Test Increment for decimal:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                decimal i = start;
                for (; i < end; i++)
                {
                }
            });
        }
    }
}
