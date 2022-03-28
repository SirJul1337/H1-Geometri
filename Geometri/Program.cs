using System;

namespace Geometri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSquare 1");
            Square sq1 = new Square(10);
            Console.WriteLine("Circumference: " + sq1.Circumference());
            Console.WriteLine("Areal: " + sq1.Area());

            Console.WriteLine("\nSquare 2");
            Square sq2 = new Square(8);
            Console.WriteLine("Circumference: " + sq2.Circumference());
            Console.WriteLine("Areal: " + sq2.Area());

            Console.WriteLine("\nSquare 3");
            Square sq3 = new Square(7);
            Console.WriteLine("Circumference: "+sq3.Circumference());
            Console.WriteLine("Areal: "+sq3.Area());


            // Assignment B
           Square sq4 = new Square();
            sq4.SideA = 5;
            Console.WriteLine("\nSquare 4");
            Console.WriteLine("Side A: ");
            Console.WriteLine(sq4.SideA);
            Console.WriteLine("Circumference: ");
            Console.WriteLine(sq4.Circumference());
            Console.WriteLine("Area: ");
            Console.WriteLine(sq4.Area());
            
        }
    }
}
