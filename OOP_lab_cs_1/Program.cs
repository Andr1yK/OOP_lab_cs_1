using System;

namespace OOP_lab_cs_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Add example of using the Line class.
            
            var line = new Line(1, 2);
            Console.WriteLine(line.Root()); // -2
            
            var line2 = new Line(2, -6);
            Console.WriteLine(line2.Root()); // 3

            var line3 = new Line(0, 2);
            Console.WriteLine(line3.Root()); // Exception
        }
    }
}