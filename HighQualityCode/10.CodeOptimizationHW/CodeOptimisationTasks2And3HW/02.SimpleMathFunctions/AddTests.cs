using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SimpleMathFunctions
{
    public static class AddTests
    {
        public static void TestForInt(int start, int end, int step)
        {
            Console.Write("Test Add for int:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                int i = start;
                for (; i < end; i += step)
                {
                    int resInt = i + 3;
                }
            });
        }

        public static void TestForLong(long start, long end, long step)
        {
            Console.Write("Test Add for long:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                long i = start;
                for (; i < end; i += step)
                {
                    long resLong = i + 3L;
                }
            });
        }

        public static void TestForFloat(float start, float end, float step)
        {
            Console.Write("Test Add for float:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                float i = start;
                for (; i < end; i += step)
                {
                    float resFloat = i + 3f;
                }
            });
        }

        public static void TestForDouble(double start, double end, double step)
        {
            Console.Write("Test Add for double:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                double i = start;
                for (; i < end; i += step)
                {
                    double resDouble = i + 3d;
                }
            });
        }

        public static void TestForDecimal(decimal start, decimal end, decimal step)
        {
            Console.Write("Test Add for decimal:\t");
            DisplayTime.DisplayExecutionTime(() =>
            {
                decimal i = start;
                for (; i < end; i += step)
                {
                    decimal resDecimal = i + 3m;
                }
            });
        }
    }
}
