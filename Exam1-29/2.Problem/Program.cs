using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger n1 = BigInteger.Parse(Console.ReadLine());
        BigInteger n2 = BigInteger.Parse(Console.ReadLine());
        BigInteger n3 = BigInteger.Parse(Console.ReadLine());
        BigInteger n4 = BigInteger.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {

                if (j == 0 &&counter<4)
                {
                    Console.Write(n1);
                    Console.Write(" ");
                    counter++;
                }
                else if (j == 1&&counter<4)
                {
                    Console.Write(n2);
                    Console.Write(" ");
                    counter++;
                }
                else if (j == 2&&counter<4)
                {
                    Console.Write(n3);
                    Console.Write(" ");
                    counter++;
                }
                else if (j == 3 && counter < 4)
                {
                    Console.Write(n4);
                    Console.Write(" ");
                    counter++;
                }
                else
                {
                   BigInteger temp = n1 + n2 + n3 + n4;
                    n1 = n2;
                    n2 = n3;
                    n3 = n4;
                    n4 = temp;
                    Console.Write(temp);
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
