using System;

namespace T02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());

            int timeForPlayInRestDays = restDays * 127;
            int timeForPlayInWorkDays = (365 - restDays) * 63;
            int timeForPlayInMinutes = timeForPlayInRestDays + timeForPlayInWorkDays;
            
            int difference = Math.Abs(30000 - timeForPlayInMinutes);
            int hours = difference / 60;
            int minutes = difference % 60;
            
            if (timeForPlayInMinutes > 30000)
            {
                Console.WriteLine($"Tom will run away\n{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine($"Tom sleeps well\n{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
