using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }
                //Check whether a triangle with such sides exists
            else if (a + b < c || a + c < b || b + c < a)
            {
                throw new ArgumentException("With such sides,triangle cannot be built");
            }
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        static string DigitToString(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Number is not in [0...9]");
            }
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null)
            {
                throw new ArgumentNullException("The array is nowhere");
            }
            else if (elements.Length == 0)
            {
                throw new ArgumentException("There is no elements");
            }

            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }
        //I change it that way because it is easier.Only two changes object number->double number PrintAsNumber->FormatNumber
        static void FormatNumber(double number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }
                
        static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2 && y1 == y2)
            {
                throw new ArgumentException("The two points are ");
            }
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static bool IsHorizontal(double y1, double y2)
        {
            return y1 == y2;
        }

        static bool IsVertical(double x1, double x2)
        {
            return x1 == x2;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(DigitToString(5));
            
            Console.WriteLine(FindMax(5,4,1,2,3,14));
            
            FormatNumber(1.2, "f");
            FormatNumber(0.75, "%");
            FormatNumber(2.30, "r");

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + IsHorizontal(-1,2.5));
            Console.WriteLine("Vertical? " + IsVertical(3,3));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
