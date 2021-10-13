using System;

namespace T01._Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string company = Console.ReadLine();
            int ticketsForAdults = int.Parse(Console.ReadLine());
            int ticketsForChildren = int.Parse(Console.ReadLine());
            double pricePerTicketForAdult = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double adultPrice = ticketsForAdults * (pricePerTicketForAdult + tax);

            double pricePerTicketForChild = pricePerTicketForAdult * 0.30 + tax;

            double childrenPrice = pricePerTicketForChild * ticketsForChildren;

            double sum = adultPrice + childrenPrice;

            double totalPrice = 0.20 * sum;

            Console.WriteLine($"The profit of your agency from {company} tickets is {totalPrice:f2} lv.");
        }
    }
}
