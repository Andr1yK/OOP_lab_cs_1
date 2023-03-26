using System;

namespace OOP_lab_cs_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // example of using the Line class.

            // Corect way to use the Line class.
            Line line = Line.Init(1, 2);
            line.Display();
            Console.WriteLine($"Root line: {line.Root()}");

            // Use read method.
            Line line2 = Line.Init(1, 1);
            line2.Read();
            line2.Display();
            Console.WriteLine($"Root line2: {line2.Root()}");

            // use setter.
            Line line3 = Line.Init(1, 2);
            line3.First = 2;
            line3.Display();
            Console.WriteLine($"Root line3: {line3.Root()}");

            // Throw exception.
            Line line4 = Line.Init(0, 0);
            line4.Display();
            Console.WriteLine($"Root: {line4.Root()}");
        }
    }
}