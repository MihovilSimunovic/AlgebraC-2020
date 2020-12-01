using System;

namespace mjesec11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite broj!");

            int broj = 13;
            try
            {
                broj = int.Parse(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                Console.WriteLine("greška, niste unijeli cijeli broj!");
            }
            catch(Exception e)
            {
                Console.WriteLine("neka druga greška!");
            }
            
            if((broj >=13) && (broj <=24))
            {
                Console.WriteLine("broj je ok!");

            }
            else
            {
                Console.WriteLine("broj mora biti izmedu 13 i 24!");
            }



            Console.ReadLine();




        }
    }
}
