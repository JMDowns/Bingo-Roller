using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo_Roller
{
    class Bingo_Card
    {
        public List<List<string>> Info { get; set; }

        public Bingo_Card(List<List<string>> info)
        {
            this.Info = info;
        }

        public void Print()
        {
            Console.WriteLine("╔═══╦═══╦═══╦═══╦═══╗");
            Console.WriteLine("║ B ║ I ║ N ║ G ║ O ║");
            Console.WriteLine("╠═══╬═══╬═══╬═══╬═══╣");
            for (int j = 0; j < 5; j++)
            {
                Console.Write("║");
                for (int i = 0; i < 5; i++)
                {
                    if (Info[i][j].Length == 1)
                        Console.Write(" " + Info[i][j] + " ║");
                    else
                        Console.Write(Info[i][j] + " ║");
                }

                if (j == 4)
                    Console.WriteLine("\n╚═══╩═══╩═══╩═══╩═══╝");
                else
                    Console.WriteLine("\n╠═══╬═══╬═══╬═══╬═══╣");
            }
        }

        public string ReturnText()
        {
            var stringList = new List<string>
            {
                "╔═══╦═══╦═══╦═══╦═══╗",
                "\n║ B ║ I ║ N ║ G ║ O ║",
                "\n╠═══╬═══╬═══╬═══╬═══╣"
            };
            for (int j = 0; j < 5; j++)
            {
                stringList.Add("\n║");
                for (int i = 0; i < 5; i++)
                {
                    if (Info[i][j].Length == 1)
                        stringList.Add(" " + Info[i][j] + " ║");
                    else
                        stringList.Add(Info[i][j] + " ║");
                }

                if (j == 4)
                    stringList.Add("\n╚═══╩═══╩═══╩═══╩═══╝");
                else
                    stringList.Add("\n╠═══╬═══╬═══╬═══╬═══╣");
            }

            return String.Join("", stringList.ToArray());
        }

        public string ReturnHTML()
        {
            var stringList = new List<string>
            {
                "<html><div style=\"font-size:36pt; font-family:Courier New;\">",
                "<p>╔═══╦═══╦═══╦═══╦═══╗",
                "<br/>║ B ║ I ║ N ║ G ║ O ║",
                "<br/>╠═══╬═══╬═══╬═══╬═══╣"
            };
            for (int j = 0; j < 5; j++)
            {
                stringList.Add("<br/>║");
                for (int i = 0; i < 5; i++)
                {
                    if (Info[i][j].Length == 1)
                        stringList.Add(" " + Info[i][j] + " ║");
                    else
                        stringList.Add(" " + Info[i][j] + "║");
                }

                if (j == 4)
                    stringList.Add("<br/>╚═══╩═══╩═══╩═══╩═══╝</p></div></html>");
                else
                    stringList.Add("<br/>╠═══╬═══╬═══╬═══╬═══╣");
            }

            return String.Join("", stringList.ToArray());
        }
    }
}
