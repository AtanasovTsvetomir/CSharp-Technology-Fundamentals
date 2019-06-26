using System;

namespace SpringVacantionTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int group = int.Parse(Console.ReadLine());
            double fuelPerKilometer = double.Parse(Console.ReadLine());
            double foodPerPersonForDay = double.Parse(Console.ReadLine());
            double priceForRoomForDayPerPerson = double.Parse(Console.ReadLine());

            double totalFood = 0;
            double priceForHotel = 0;
            double reduce = 0;

            totalFood = foodPerPersonForDay * group * days;
            priceForHotel = priceForRoomForDayPerPerson * days * group;

            if (group > 10)
            {
                priceForHotel = priceForHotel - (priceForHotel * 0.25);
            }

            double currentExpenses = totalFood + priceForHotel;

            for (int i = 1; i <= days; i++)
            {
                double travelledDistance = double.Parse(Console.ReadLine());

                double priceForGas = travelledDistance * fuelPerKilometer;
                currentExpenses += priceForGas;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 15 == 0)
                    {
                        currentExpenses += 0.40 * currentExpenses;
                    }
                    else
                    {
                        currentExpenses += 0.40 * currentExpenses;
                    }
                }
                if (i % 7 == 0)
                {
                    reduce = currentExpenses / group;
                    currentExpenses -= reduce;
                }
                if (currentExpenses > budget)
                {
                    double neededMoney = currentExpenses - budget;
                    Console.WriteLine($"Not enough money to continue the trip. You need {neededMoney:f2}$ more.");
                    return;
                }
            }
            double total = Math.Abs(budget - currentExpenses);

            if (budget >= currentExpenses)
            {
                Console.WriteLine($"You have reached the destination. You have {total:f2}$ budget left.");
            }
            else
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {total}$ more.");
            }

        }
    }
}
