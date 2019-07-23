using System;
using System.Collections.Generic;

namespace CoinCombo
{
    


    class FrontEnd
    {
        static Dictionary<string, int> Coins = new Dictionary<string, int>();

        public static void Main()
        {
            bool goAgain = true;
            int userAmount= 0;
            do
            {
                Console.WriteLine("Please enter ammount of ¢ cents you have ");
                try
                {
                    userAmount = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("You did not enter a valid amount, please try again\n");
                    userAmount = -1;
                }
                do
                {
                    if (userAmount >=25)
                    {
                        userAmount = CoinLogic.countQuarters(userAmount);
                    }
                    if (userAmount >= 10)
                    {
                        userAmount = CoinLogic.countDimes(userAmount);
                    } else if (userAmount >= 5)
                    {
                        userAmount = CoinLogic.countNickles(userAmount);
                    } else if (userAmount > 0)
                    {
                        userAmount = CoinLogic.countPennies(userAmount);
                    }
                } while (userAmount > 0);
                if (userAmount != -1)
                {
                    Coins.Clear();
                    Coins = CoinLogic.CoinFilter();
                    Console.WriteLine("Here is the change you recieve:");
                    foreach ( KeyValuePair<string, int> key in Coins)
                    {
                        Console.WriteLine(key.Key+ " : "+ key.Value);
                    }
                }
                Console.WriteLine("Would you like to know more?");
                string consent = Console.ReadLine();
                if (consent == "no" || consent == "n")
                {
                    goAgain = false;
                }
            } while (goAgain == true);
        }
    }
}