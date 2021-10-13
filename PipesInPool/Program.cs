using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double face = (double)(b1 + b2) * h / 2;
            Console.WriteLine($"{face:f2}");
        }
    }
}
