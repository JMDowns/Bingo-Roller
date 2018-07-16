using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo_Roller
{
    static class Caller
    {
        static public void Call()
        {
            var answer = "";
            do
            {
                var alreadyCalled = new List<int>();
                var random = new Random();
                var number = random.Next(1, 75);
                string bingoSpot;

                while (alreadyCalled.Contains(number))
                {
                    number = random.Next(1, 75);
                }

                if (number <= 15)
                    bingoSpot = "B" + number;
                else if (number <= 30)
                    bingoSpot = "I" + number;
                else if (number <= 45)
                    bingoSpot = "N" + number;
                else if (number <= 60)
                    bingoSpot = "G" + number;
                else
                    bingoSpot = "O" + number;

                Console.Write("Do you want to call again? [y][n]");
                answer = Console.ReadLine();
            } while (answer == "y");  
        }
    }
}
