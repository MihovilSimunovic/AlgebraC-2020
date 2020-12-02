using System;

namespace Prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Unesite godinu:");
            int year = 0;

            try
            {
                year = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Greška, morate unijeti broj!");
                Console.WriteLine(ex.Message);
                //throw ex;
            }
            

            if ((year % 4 == 0 && (!(year % 100 == 0))) || (year % 400 == 0))
                Console.WriteLine("Godina {0}. je prijestupna.", year);
            else
                Console.WriteLine("Godina {0}. nije prijestupna!", year);
            

            //Ispis prijestupnih godina od 1900 do 2007
            Console.WriteLine("Prijestupne godine od 1900. do 2007. su:");
            for (int i = 1900; i <= 2007; i++)
            {
                
                if ((i % 4 == 0 && (!(i % 100 == 0))) || (i % 400 == 0))
                {
                    Console.WriteLine("Godina {0}. ", i.ToString());
                }
            }
            
            Console.WriteLine("Pritisnite Enter za kraj..");
            Console.ReadLine();
        }
    }
}
