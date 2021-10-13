using System;

namespace T02._Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceLaugageOver20Kilos = double.Parse(Console.ReadLine());
            double lougageKilos = double.Parse(Console.ReadLine());
            int daysTillTrip = int.Parse(Console.ReadLine());
            int lougageCount = int.Parse(Console.ReadLine());

            double lougagePrice = 0;

            if (lougageKilos <= 10)
            {
                lougagePrice = 0.20 * priceLaugageOver20Kilos;
            }
            else if (lougageKilos <= 20)
            {
                lougagePrice = 0.50 * priceLaugageOver20Kilos;
            }
            else
            {
                double tax = double.Parse(Console.ReadLine());
                lougagePrice = tax * priceLaugageOver20Kilos;
            }
            if (daysTillTrip > 30)
            {
                lougagePrice += 0.10 * lougagePrice;
            }
            else if (daysTillTrip <= 30 && daysTillTrip >= 7)
            {
                lougagePrice += 0.15 * lougagePrice;
            }
            else 
            {
                lougagePrice += 0.40 * lougagePrice;
            }
            double total = lougagePrice * lougageCount;
            Console.WriteLine($"The total price of bags is: {total:f2} lv.");
        }
    }
}
