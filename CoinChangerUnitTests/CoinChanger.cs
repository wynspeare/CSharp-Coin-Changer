using System.Collections;
using System.Collections.Generic;
using System;


namespace coinChanger
{
    public class MakeChange
    {
        public Dictionary<string, int> calculateChange(int amount)
        {
            var remainder = amount;
            Dictionary<string, int> change =  new Dictionary<string, int>(); 

            while (remainder != 0)
            {
                if (remainder >= 25) 
                {
                    int numberOfQuarters = remainder / 25;
                    change.Add("Quarter", numberOfQuarters); 
                }

                else if (remainder >= 10)
                {
                    int numberOfDimes = remainder / 10;
                    change.Add("Dime", numberOfDimes); 
                }
                else if (remainder >= 5)
                {
                    change.Add("Nickel", 1);
                    remainder -= 5;
                }
                else
                {
                    change.Add("Penny", remainder);
                    remainder = 0;
                }
            }
            return change;
        }
        
        public string displayChange(int amount)
        {
            var change = calculateChange(amount);
            var returnedChange = String.Format("{0} has been converted to the following coins: ", amount);
			foreach (KeyValuePair<string, int> coin in change)
			{
                returnedChange += "x" + coin.Value.ToString() + " " + coin.Key + " ";
			}
            Console.WriteLine(returnedChange);
            return returnedChange;
            
        }
    }
}