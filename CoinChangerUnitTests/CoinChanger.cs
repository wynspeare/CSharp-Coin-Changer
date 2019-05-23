using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

namespace coinChanger
{
    public class MakeChange
    {

        List<int> change = new List<int>();
        static readonly int[] possibleCoins = { 25, 10, 5, 1 };

        public List<int> calculateChange(int amount)
        {
            var remainder = amount;
            foreach (int coin in possibleCoins)
            {
                if (remainder >= coin)
                {
                    int numberOfCoins = remainder / coin;
                    change.AddRange(Enumerable.Repeat(coin, numberOfCoins));
                    remainder -= (coin * numberOfCoins);
                }
            }
            return change;
        }

        public Dictionary<int, int> countChange()
        {
            var coinCounts = new Dictionary<int, int>();
			foreach (int coin in change)
			{
                if (!coinCounts.ContainsKey(coin))
                {
                    coinCounts[coin] = 1;
                }
                else
                {
                    coinCounts[coin] += 1;
                }
			}
            return coinCounts;
        }
        
        public string displayChange(int amount)
        {
            var coinCounts = countChange();
            var returnedChange = String.Format("{0} has been converted to the following coins:\n", amount);
			foreach (KeyValuePair<int, int> coin in coinCounts)
			{
                returnedChange += "x" + coin.Value.ToString() + " " + coin.Key + "\n";
			}
            Console.WriteLine(returnedChange);
            return returnedChange;
        }

    }
}