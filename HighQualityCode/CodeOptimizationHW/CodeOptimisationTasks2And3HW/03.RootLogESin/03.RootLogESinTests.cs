using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RootLogESin
{
    class RootLogESinTests
    {
        static void Main(string[] args)
        {
            SquareRootTests.TestForFloat(1f, 1000000f, 2f);
            SquareRootTests.TestForDouble(1d, 1000000d, 2d);
            SquareRootTests.TestForDecimal(1m, 1000000m, 2m);

            Console.WriteLine();

            NaturalLogarithmTests.TestForFloat(1f, 1000000f, 2f);
            NaturalLogarithmTests.TestForDouble(1d, 1000000d, 2d);
            NaturalLogarithmTests.TestForDecimal(1m, 1000000m, 2m);

            Console.WriteLine();

            SinTests.TestForFloat(1f, 1000000f, 2f);
            SinTests.TestForDouble(1d, 1000000d, 2d);
            SinTests.TestForDecimal(1m, 1000000m, 2m);
        }
    }
}
