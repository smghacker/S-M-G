using System;
using System.Linq;

namespace _01.BoolExtension
{
    public class BoolExtenstion
    {
        private const int MaxCount = 6;

        public static void Main()
        {
            BoolExtenstion.Methods instance = new BoolExtenstion.Methods();
            instance.PrintBoolAsString(true);
        }

        public class Methods
        {
            public void PrintBoolAsString(bool currentBool)
            {
                string currentBoolAsString = currentBool.ToString();
                Console.WriteLine(currentBoolAsString);
            }
        }
    }
}
