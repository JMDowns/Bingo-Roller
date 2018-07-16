using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo_Roller
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardAmount = Verifier.VerifyAsk();
            var cardList = new List<Bingo_Card>();
            var card1 = Card_Maker.Create_Card();
            for (int i = 0; i < cardAmount; i++)
                cardList.Add(Card_Maker.Create_Card());
            foreach (Bingo_Card card in cardList)
            {
                card.Print();
            }
            //TextFileCreator.Create_Text(cardList);
            TextFileCreator.Create_HTML(cardList);
        }
    }
}
