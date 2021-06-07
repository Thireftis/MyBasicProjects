using System;

namespace n3
{
    class Program
    {
        static void Main(string[] args)
        {




            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string oppinion = Console.ReadLine();

            int nights = days - 1;
          
            if (type == "room for one person")
            {
                if (oppinion == "positive")
                {
                    int totalprice = nights * 18;
                    Console.WriteLine($"{totalprice + (0.25 * totalprice):F2}");
                }
                else if (oppinion == "negative")
                {
                    int totalprice = nights * 18;
                    Console.WriteLine($"{totalprice - (0.1 * totalprice):F2}");
                }
            }
            
            if (type == "apartment")
            {
                if (oppinion == "positive")
                {
                    if (nights < 10)
                    {
                        double totalPrice = nights * 25;
                        double discountedPrice = totalPrice - (0.3 * totalPrice);
                        Console.WriteLine($"{discountedPrice + (0.25 * discountedPrice):F2}");
                    }
                    else if (nights > 10 && nights < 15)
                    {
                        double totalPrice = nights * 25;
                        double discountedPrice = totalPrice - (0.35 * totalPrice);
                        Console.WriteLine($"{discountedPrice + (0.25 * discountedPrice):F2}");
                    }
                    else if (nights > 15)
                    {
                        double totalPrice = nights * 25;
                        double discountedPrice = totalPrice - (0.5 * totalPrice);
                        Console.WriteLine($"{discountedPrice + (0.25 * discountedPrice):F2}");
                    }
                }
                else if (oppinion == "negative")
                {
                    if (nights < 10)
                    {
                        double totalPrice = nights * 25;
                        double discountedPrice = totalPrice - (0.3 * totalPrice);
                        Console.WriteLine($"{discountedPrice - (0.1 * discountedPrice):F2}");
                    }
                    else if (nights > 10 && nights < 15)
                    {
                        double totalPrice = nights * 25;
                        double discountedPrice = totalPrice - (0.35 * totalPrice);
                        Console.WriteLine($"{discountedPrice - (0.1 * discountedPrice):F2}");
                    }
                    else if (nights > 15)
                    {
                        double totalPrice = nights * 25;
                        double discountedPrice = totalPrice - (0.5 * totalPrice);
                        Console.WriteLine($"{discountedPrice - (0.1 * discountedPrice):F2}");
                    }
                }
            }

          
            if (type == "president apartment")
            {
                if (oppinion == "positive")
                {
                    if (nights < 10)
                    {
                        double totalPrice = nights * 35;
                        double discountedPrice = totalPrice - (0.1 * totalPrice);
                        Console.WriteLine($"{discountedPrice + (0.25 * discountedPrice):F2}");
                    }
                    if (nights > 10 && nights < 15)
                    {
                        double totalPrice = nights * 35;
                        double discountedPrice = totalPrice - (0.15 * totalPrice);
                        Console.WriteLine($"{discountedPrice + (0.25 * discountedPrice):F2}");
                    }
                    if (nights > 15)
                    {
                        double totalPrice = nights * 35;
                        double discountedPrice = totalPrice - (0.2 * totalPrice);
                        Console.WriteLine($"{discountedPrice + (0.25 * discountedPrice):F2}");
                    }
                }
                else if (oppinion == "negative")
                {
                    if (nights < 10)
                    {
                        double totalPrice = nights * 35;
                        double discountedPrice = totalPrice - (0.1 * totalPrice);
                        Console.WriteLine($"{discountedPrice - (0.1 * discountedPrice):F2}");
                    }
                    if (nights > 10 && nights < 15)
                    {
                        double totalPrice = nights * 35;
                        double discountedPrice = totalPrice - (0.15 * totalPrice);
                        Console.WriteLine($"{discountedPrice - (0.1 * discountedPrice):F2}");
                    }
                    if (nights > 15)
                    {
                        double totalPrice = nights * 35;
                        double discountedPrice = totalPrice - (0.2 * totalPrice);
                        Console.WriteLine($"{discountedPrice - (0.1 * discountedPrice):F2}");
                    }}}}}}