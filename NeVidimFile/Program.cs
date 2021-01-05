using System;
using System.IO;

namespace NeVidimFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Molim unesite nekakav text");

            string txt = Console.ReadLine();

            //handle koji kreira file i/ili pregazi postojeci
            //FileStream fs1 = new FileStream("Proba.txt", FileMode.Create); //FileStream("Proba.txt", 2);

            // handfle koji dodaje na kraj filea
            FileStream fs1 = new FileStream("Test.txt", FileMode.Append); //FileStream("Proba.txt", 6);

            StreamWriter sw1 = new StreamWriter(fs1);

            sw1.WriteLine(txt);

            sw1.Flush();
            sw1.Close();
            fs1.Close();






        }
    }
}
