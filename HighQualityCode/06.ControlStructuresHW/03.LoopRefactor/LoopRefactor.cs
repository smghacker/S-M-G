using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Loop_refactor
{
    class LoopRefactor
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int i = 0;
            for (; i < array.Length; i++)
            {
                array[i] = i;
            }

            i = 0;
            bool isValueFound = false;
            int expectedValue = 1;
            for (; i < 100; i++)
            {
                Console.WriteLine(array[i]);
                if ((i % 10 == 0) && (array[i] == expectedValue))
                {
                    isValueFound = true;
                    break;
                }
            }
            // More code here
            if (isValueFound)
            {
                Console.WriteLine("Value Found");
            }

        }
    }
}

