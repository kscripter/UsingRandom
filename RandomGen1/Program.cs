using System;

namespace RandomGen1
{
    class Program
    {
        static void Main(string[] args)
        {


            //using for loop for opening balance and withdrawal

            Random newRandom = new Random();

            double Openingbalance = newRandom.Next(5000, 10000);

            for (; Openingbalance > 0;)
            {
                double WithdrawalAmount = newRandom.Next(1, 100);

                Openingbalance -= WithdrawalAmount;

                Console.WriteLine($" New Balanace {Openingbalance}");
                Console.WriteLine($" Withdrawing {WithdrawalAmount}");
            }



            //for (int x = 5000; x < 10000; x++)

            //{
            //    int y = newRandom.Next(5000, 10000);


            //    Console.WriteLine($"{y}");

            //}

        }
    }
}
