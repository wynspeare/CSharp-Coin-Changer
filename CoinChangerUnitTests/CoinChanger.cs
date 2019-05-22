using System.Collections;
using System.Collections.Generic;
using System;


namespace coinChanger
{
    public class MakeChange
    {
        public int[] calculateChange(int amount)
        {
            var remainder = amount;
            List<int> change = new List<int>();
            while (remainder != 0)
            {
                if (remainder >= 25) 
                {
                    int numberOfQuarters = remainder / 25;
                    for (int i = 0; i < numberOfQuarters; i++)
                    {
                        change.Add(25);
                        remainder -= 25;
                    }
                }
                else if (remainder >= 10)
                {
                    int numberOfDimes = remainder / 10;
                    for (int i = 0; i < numberOfDimes; i++)
                    {
                        change.Add(10);
                        remainder -= 10;
                    }
                }
                else if (remainder >= 5)
                {
                    change.Add(5);
                    remainder -= 5;
                }
                else
                {
                    change.Add(1);
                    remainder--;
                }
            }
            int[] convertedChange = change.ToArray();
            displayChange(convertedChange, amount);
            return convertedChange;
        }

        public static void displayChange(int[] change, int amount)
        {
            Console.WriteLine("\nYou have this much change for {0}:", amount);
            foreach (int coin in change)
            {
                Console.Write(coin + "   ");
            }
        }
    }
}