using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SimpleMathFunctions
{
    static class AllFunctionsTest
    {
        static void Main()
        {
            AddTests.TestForInt(1, 1000000, 2);
            AddTests.TestForLong(1L, 1000000L, 2L);
            AddTests.TestForFloat(1f, 1000000f, 2f);
            AddTests.TestForDouble(1d, 1000000d, 2d);
            AddTests.TestForDecimal(1m, 1000000m, 2m);

            Console.WriteLine();

            SubstractionTests.TestForInt(1, 1000000, 2);
            SubstractionTests.TestForLong(1L, 1000000L, 2L);
            SubstractionTests.TestForFloat(1f, 1000000f, 2f);
            SubstractionTests.TestForDouble(1d, 1000000d, 2d);
            SubstractionTests.TestForDecimal(1m, 1000000m, 2m);

            Console.WriteLine();

            MultiplyTests.TestForInt(1, 1000000, 2);
            MultiplyTests.TestForLong(1L, 1000000L, 2L);
            MultiplyTests.TestForFloat(1f, 1000000f, 2f);
            MultiplyTests.TestForDouble(1d, 1000000d, 2d);
            MultiplyTests.TestForDecimal(1m, 1000000m, 2m);

            Console.WriteLine();

            DivisionTests.TestForInt(1, 1000000, 2);
            DivisionTests.TestForLong(1L, 1000000L, 2L);
            DivisionTests.TestForFloat(1f, 1000000f, 2f);
            DivisionTests.TestForDouble(1d, 1000000d, 2d);
            DivisionTests.TestForDecimal(1m, 1000000m, 2m);


            Console.WriteLine();

            IncrementTests.TestForInt(1, 1000000, 2);
            IncrementTests.TestForLong(1L, 1000000L, 2L);
            IncrementTests.TestForFloat(1f, 1000000f, 2f);
            IncrementTests.TestForDouble(1d, 1000000d, 2d);
            IncrementTests.TestForDecimal(1m, 1000000m, 2m);
        }
    }
}
