using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrintStatistics_refactor
{
    class PrintStatistics
    {
        static void Main(string[] args)
        {
        }

        public double FindMax(double[] arr, int count)
        {
            double max=double.MinValue;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        public double FindMin(double[] arr, int count)
        {
            double min = double.MaxValue;

            for (int i = 0; i < count; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        public long FindAverage(double[] arr, int count)
        {
            long sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += (long)arr[i];
            }

            return sum;
        }

        public void PrintStatistics(double[] arr, int count)
        {
            Console.WriteLine(FindMax(arr, count));
            Console.WriteLine(FindMin(arr, count));
            Console.WriteLine(FindAverage(arr, count));
        }
    }
}
