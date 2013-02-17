using System;
class Program
{
    static void Main()
    {
        string str =Console.ReadLine();
        int n = int.Parse(str);
        int length=str.Length;
        for (int i = 0; i < 3; i++)
        {
            if (n % 10 == 0)
            {
                n = n / 10 + (n % 10) * (int)Math.Pow(10, length - 1);
                length--;
            }
            else
            {
                n = n / 10 + (n % 10) * (int)Math.Pow(10, length - 1);
            }
        }
        Console.WriteLine(n);
    }
}
