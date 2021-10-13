using System;

namespace T01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double fullynessOfThePool = (double)(p1 + p2) * hours;

                if (fullynessOfThePool <= volume)
                {
                    double convertPool = fullynessOfThePool / volume * 100;
                    double convertP1 = (double)p1 * hours / fullynessOfThePool * 100;
                    double convertP2 = (double)p2 * hours / fullynessOfThePool * 100;
                    Console.WriteLine($"The pool is {convertPool:f2}% full. Pipe 1: {convertP1:f2}%. Pipe 2: {convertP2:f2}%.");
                }
                else
                {
                    Console.WriteLine($"For {hours:f2} hours the pool overflows with {(fullynessOfThePool - volume):f2} liters.");
                }
        }
    }
}
