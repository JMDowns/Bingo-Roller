using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo_Roller
{
    static class TextFileCreator
    {
        static public void Create_Text(List<Bingo_Card> cardList)
        {
            string nameAndExtension = @"\bingo\bingo.txt";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + nameAndExtension;
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            foreach (Bingo_Card card in cardList)
            {
                try
                {
                    using (FileStream fs = File.Create(path))
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes(card.ReturnText());
                        fs.Write(info, 0, info.Length);
                    }

                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        static public void Create_HTML(List<Bingo_Card> cardList)
        {
            //var myGuid = new Guid();
            string nameAndExtension = @"\bingo\bingo.html";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) /*+ myGuid*/ + nameAndExtension;
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            foreach (Bingo_Card card in cardList)
            {
                try
                {
                    using (FileStream fs = File.Create(path))
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes(card.ReturnHTML());
                        fs.Write(info, 0, info.Length);
                    }

                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
