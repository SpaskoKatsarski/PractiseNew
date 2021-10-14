using System;

namespace T05._Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentPlayer = String.Empty;
            string bestPlayer = string.Empty;
            int mostGoals = int.MinValue;

            string input = Console.ReadLine();
            while (input != "END")
            {
                currentPlayer = input;
                int markedGoals = int.Parse(Console.ReadLine());

                if (markedGoals > mostGoals)
                {
                    bestPlayer = currentPlayer;
                    mostGoals = markedGoals;

                    if (mostGoals >= 10)
                    {
                        Console.WriteLine($"{bestPlayer} is the best player!\nHe has scored {mostGoals} goals and made a hat-trick !!!");
                        return; 
                    }
                }
                input = Console.ReadLine();
            }
            if (mostGoals >= 3)
            {
                Console.WriteLine($"{bestPlayer} is the best player!\nHe has scored {mostGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{bestPlayer} is the best player!\nHe has scored {mostGoals} goals.");
            }
        }
    }
}
