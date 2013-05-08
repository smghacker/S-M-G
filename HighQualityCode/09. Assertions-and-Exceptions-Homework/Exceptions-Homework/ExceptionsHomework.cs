using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null)
        {
            throw new ArgumentNullException("arr", "Array can't be null!");
        }
        if (startIndex < 0 || startIndex >= arr.Length)
        {
            throw new ArgumentOutOfRangeException
                ("startIndex", "Index from which you to start must be non-negative and smaller than the length of the array");
        }
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException("count", "The number of elements that you want to get must be positive");
        }

        //This is from normal work flow
        if (startIndex + count > arr.Length)
        {
            return arr;
        }


        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str", "String can't be null");
        }

        if (count < 0)
        {
            throw new ArgumentException("Nuumber of elements that you want to take must be positive", "count");
        }

        if (count > str.Length)
        {
            return str;
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static string CheckPrime(int number)
    {
        //If we put a negative number we would recieve an exception because Sqrt works with positive numbers
        //that's why i put Math.Abs and we make the program more robust, because this is the normal flow of work :)
        for (int divisor = 2; divisor <= Math.Sqrt(Math.Abs(number)); divisor++)
        {
            if (number % divisor == 0)
            {
                return "The number is not prime!";
            }
        }
        return "The number is prime!";
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 5);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 100));

        Console.WriteLine(CheckPrime(23));
        Console.WriteLine(CheckPrime(33));
        Console.WriteLine(CheckPrime(-3));

        try
        {
            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0)
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average result = {0:P0}", peterAverageResult);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        //--------Cases with exceptions --------
        try
        {
            //Negative count
            //var negCountArr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, -5);
            //Console.WriteLine(String.Join(" ", subarr));

            //Negative startIndex
            //var negStartArr = Subsequence(new int[] { -1, 3, 2, 1 }, -3, 3);
            //Console.WriteLine(String.Join(" ", subarr));

            //Console.WriteLine(ExtractEnding("I love C#", -1));
            //Console.WriteLine(ExtractEnding(null, 23));
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        //-------End of Cases with exceptions --------
    }
}
