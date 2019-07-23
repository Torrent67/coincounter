using System;
using System.Collections.Generic;

namespace CoinCombo
{

    class CoinLogic
    {
        private static Dictionary<string, int> Coins = new Dictionary<string, int>();
        private static int totalQuarters;
        private static int quarter = 25;
        private static int totalDimes;
        private static int dime = 10;
        private static int totalNickles;
        private static int nickle = 5;
        private static int totalPennies;
        private static int pennies = 1;


        public static int countQuarters(int amount)
        {
            do
            {
                amount -= quarter;
                totalQuarters++;

            } while (amount - quarter >= 0);
            return amount;
        }
        public static int countDimes(int amount)
        {
            do
            {
                amount -= dime;
                totalDimes++;

            } while (amount - dime >= 0);
            return amount;
        }
        public static int countNickles(int amount)
        {
            do
            {
                amount -= nickle;
                totalNickles++;

            } while (amount - nickle >= 0);
            return amount;            
        }
        public static int countPennies(int amount)
        {
            do
            {
                amount -= pennies;
                totalPennies++;

            } while (amount - pennies >= 0);
            return amount;            
        }
        public static Dictionary<string, int> CoinFilter()
        {
            Coins.Clear();
            Coins.Add("quarters", totalQuarters);
            Coins.Add("dimes", totalDimes);
            Coins.Add("nickles", totalNickles);
            Coins.Add("pennies", totalPennies);
            totalQuarters = 0;
            totalDimes = 0;
            totalNickles = 0;
            totalPennies = 0;
            return Coins;
        }

    }

}