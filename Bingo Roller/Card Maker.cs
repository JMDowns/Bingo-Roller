using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bingo_Roller
{
    static class Card_Maker
    {
        static public Bingo_Card Create_Card()
        {
            var random = new Random();
            Thread.Sleep(16);
            var bRow = new List<string>() { };
            var iRow = new List<string>() { };
            var nRow = new List<string>() { };
            var gRow = new List<string>() { };
            var oRow = new List<string>() { };

            while (bRow.Count <= 5)
            {
                var number = random.Next(1, 15);
                if (!bRow.Contains(number.ToString()))
                    bRow.Add(number.ToString());
            }

            while (iRow.Count <= 5)
            {
                var number = random.Next(16, 30);
                if (!iRow.Contains(number.ToString()))
                    iRow.Add(number.ToString());
            }

            while (nRow.Count <= 5)
            {
                var number = random.Next(31, 45);
                if (!nRow.Contains(number.ToString()))
                    nRow.Add(number.ToString());
            }

            while (gRow.Count <= 5)
            {
                var number = random.Next(46, 60);
                if (!gRow.Contains(number.ToString()))
                    gRow.Add(number.ToString());
            }

            while (oRow.Count <= 5)
            {
                var number = random.Next(61, 75);
                if (!oRow.Contains(number.ToString()))
                    oRow.Add(number.ToString());
            }

            var card = new List<List<string>>() { bRow, iRow, nRow, gRow, oRow };
            card[2][2] = "F";

            return new Bingo_Card(card);
        }
    }
}
