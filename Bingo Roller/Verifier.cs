using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo_Roller
{
    static class Verifier
    {
        static public int VerifyAsk()
        {
            string cardAmountString;
            var cardAmount = 0;
            while (cardAmount <= 0)
            {
                Console.WriteLine("How many cards do you want?");
                cardAmountString = Console.ReadLine();
                try
                {
                    cardAmount = Int32.Parse(cardAmountString);
                }
                catch (Exception e)
                {
                    if (e is FormatException || e is ArgumentNullException)
                    {
                        Console.WriteLine("Please enter a valid number above zero.");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a smaller number above zero.");
                        continue;
                    }
                }

                if (cardAmount <= 0)
                {
                    Console.WriteLine("Please enter a number above zero.");
                    continue;
                }
            }

            return cardAmount;
        }
    }
}
