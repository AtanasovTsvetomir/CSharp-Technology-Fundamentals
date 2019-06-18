using System;

namespace _03_Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            double groupCount = double.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            switch (day)
            {
                case "Friday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            price = 8.45;
                            break;
                        case "Business":
                            price = 10.90;
                            break;
                        case "Regular":
                            price = 15;
                            break;
                    }
                    break;
                case "Saturday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            price = 9.80;
                            break;
                        case "Business":
                            price = 15.60;
                            break;
                        case "Regular":
                            price = 20;
                            break;
                    }
                    break;
                case "Sunday":
                    switch (typeOfGroup)
                    {
                        case "Students":
                            price = 10.46;
                            break;
                        case "Business":
                            price = 16;
                            break;
                        case "Regular":
                            price = 22.50;
                            break;
                    }
                    break;
            }
            double sum = groupCount * price;
            double total = 0;

            if (typeOfGroup == "Students" &&  groupCount >= 30)
            {
                total = sum - (sum * 0.15);
                Console.WriteLine($"Total price: {total:f2}");
            }
            else if (typeOfGroup == "Business" && groupCount >= 100)
            {
                total = (groupCount - 10) * price;
                Console.WriteLine($"Total price: {total:f2}");
            }
            else if (typeOfGroup == "Regular" && groupCount >= 10 && groupCount <= 20)
            {
                total = sum - (sum * 0.05);
                Console.WriteLine($"Total price: {total:f2}");
            }
            else
            {
                Console.WriteLine($"Total price: {sum:f2}");
            }

        }
    }
}
