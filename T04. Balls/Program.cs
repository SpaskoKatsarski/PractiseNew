using System;

namespace T04._Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double pointsFromRed = 0;
            double pointsFromOrange = 0;
            double pointsFromYellow = 0;
            double pointsFromWhite = 0;
            double black = 0;
            double totalPoints = 0;
            int otherColours = 0;

            for (int i = 0; i < n; i++)
            {
                string colour = Console.ReadLine();
                if (colour == "red")
                {
                    pointsFromRed++;
                    totalPoints += 5;
                }
                else if (colour == "orange")
                {
                    pointsFromOrange++;
                    totalPoints += 10;
                }
                else if (colour == "yellow")
                {
                    pointsFromYellow++;
                    totalPoints += 15;
                }
                else if (colour == "white")
                {
                    pointsFromWhite++;
                    totalPoints += 20;
                }
                else if (colour == "black")
                {
                    black++;
                    totalPoints = Math.Floor(totalPoints / 2);
                }
                else
                {
                    otherColours++;
                }
            }
            Console.WriteLine($"Total points: {totalPoints}\nPoints from red balls: {pointsFromRed}\nPoints from orange balls: {pointsFromOrange}\nPoints from yellow balls: {pointsFromYellow}\nPoints from white balls: {pointsFromWhite}\nOther colors picked: {otherColours}\nDivides from black balls: {black}");
        }
    }
}
