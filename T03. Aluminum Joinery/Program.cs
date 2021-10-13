using System;

namespace T03._Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int joineries = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string choice = Console.ReadLine();

            double total = 0;

            if (joineries <= 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            if (type == "90X130")
            {
                total = 110 * joineries;
                if (joineries > 30 && joineries <= 60)
                {
                    total *= 0.95;
                }
                else if (joineries > 60)
                {
                    total *= 0.92;
                }
            }
            else if (type == "100X150")
            {
                total = 140 * joineries;
                if (joineries > 40 && joineries <= 80)
                {
                    total *= 0.94;
                }
                else if (joineries > 80)
                {
                    total *= 0.90;
                }
            }
            else if (type == "130X180")
            {
                total = 190 * joineries;
                if (joineries > 20 && joineries <= 50)
                {
                    total *= 0.93;
                }
                else if (joineries > 50)
                {
                    total *= 0.88;
                }
            }
            else
            {
                total = 250 * joineries;
                if (joineries > 25 && joineries <= 50)
                {
                    total *= 0.91;
                }
                else if (joineries > 50)
                {
                    total *= 0.86;
                }
            }
            if (choice == "With delivery")
            {
                total += 60;
            }
            if (joineries > 99)
            {
                total *= 0.96;
            }
            Console.WriteLine($"{total:f2} BGN");
        }
    }
}
