using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == (n / 2 ) && i == j)
                {
                    Console.Write("*");
                }
                else if (i == (n / 2 ))
                {
                    Console.Write("-");
                }
                else if (j == (n / 2 ))
                {
                    Console.Write("|");
                }

                else if (i == j && i != (n / 2 ))
                {
                    Console.Write("\\");

                }
                else if (i + j == n - 1)
                {
                    Console.Write("/");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}