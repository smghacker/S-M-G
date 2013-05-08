using System;

namespace Abstraction
{
    class FiguresExample
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine("I am a circle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                circle.CalcPerimeter(), circle.CalcSurface());

            Rectangle rect = new Rectangle(2, 3);
            Console.WriteLine("I am a rectangle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                rect.CalcPerimeter(), rect.CalcSurface());

            //Test the circle encapsulation
            try
            {
                Circle circle2 = new Circle(-3);
                Console.WriteLine("I am a circle. " +
                    "My perimeter is {0:f2}. My surface is {1:f2}.",
                    circle2.CalcPerimeter(), circle2.CalcSurface());

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //Test the rectangle encapsulation
            try
            {
                Rectangle rect3 = new Rectangle(2, 0);
            Console.WriteLine("I am a rectangle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                rect.CalcPerimeter(), rect.CalcSurface());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Rectangle rect2 = new Rectangle(-2, 3);
                Console.WriteLine("I am a rectangle. " +
                    "My perimeter is {0:f2}. My surface is {1:f2}.",
                    rect.CalcPerimeter(), rect.CalcSurface());

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
