using System;

namespace Zadaca_16__2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*      // Malo da zaokruzimo svo do sada znanje:
                    // Objekti, Liste, Metode, staticke varijable, reference

                    1. Kreirati objekt Kolac
                    2. Program:
                     - Kreiraj objekt Kolac K1 -> "Cokoladna ekstaza"
                     // sastojke dodati u listu unutar kolaca
                     - K1.DodajSastojak("Margarin",200) 
                     - K1.DodajSastojak("Secer",100)
                     - K1.DodajSastojak("Cokolada",300) 
                     - K1.DodajSastojak("Jaje",50) //g
                     - Rerna.Ispeci(ref K1)   // Staticka klasa rerna, ne moze se instancirati
                     - Ponovi sve sa K2

                    3. Console.Writeline(K1)
                     - Ako je kolac pecen ispisi "kolac je pecen" (boolean)
                     - Ispisi sastojke
                     - Ispisi ukupnu masu kolaca kao zbroj sastojaka ( U KG, NA DVIJE DECIMALE)


                    4. K1.DodajSastojak("Limun",100)
                      - dodaj uvjet, ako je kolac pecen ne dozvoli dodavanje sastojaka
             */

           Kolac K1 = new Kolac();

            K1.DodajSastojak("Margarin", 200);
            K1.DodajSastojak("Secer", 100);
            K1.DodajSastojak("Cokolada", 300);
            K1.DodajSastojak("Jaje", 50);
            Rerna.Ispeci(ref K1);


            Kolac K2 = new Kolac();
            K2.DodajSastojak("Margarin", 300);
            K2.DodajSastojak("Secer", 80);
            K2.DodajSastojak("Cokolada", 300);
            K2.DodajSastojak("Jaje", 150);
            Rerna.Ispeci(ref K2);


            Console.WriteLine(K1);
            Console.WriteLine(K2);
            K1.DodajSastojak("Limun", 100);
            K2.DodajSastojak("Limun", 50);
            Console.WriteLine("Broj ispečenih kolača je " + Rerna.BrojIspecenihKolaca.ToString());


            Console.WriteLine("Pritisnite Enter za kraj..");
            Console.ReadLine();
        }
    }
}
