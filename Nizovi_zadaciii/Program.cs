using System;
using System.Collections;

namespace Nizovi_zadaciii
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6.2.4 Ispis znamenki naopako
            Console.Write("Unesite prirodan broj: ");
            int broj = int.Parse(Console.ReadLine());
            ArrayList arr = new ArrayList();

            while (broj > 0)
            {
                arr.Add(broj % 10);
                broj /= 10;
            }
            Console.WriteLine("Ispis znamenki naopako: ");

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i]);

            }
            Console.WriteLine();


            // 6.2.5 Prosti faktori
            Console.Write("Unesite prirodan broj: ");
            int brojj = int.Parse(Console.ReadLine());
            int faktor = 2;
            Console.Write("{0} = ", brojj);
            ArrayList ar = new ArrayList();

            while (faktor <= brojj)
            {
                if (brojj % faktor == 0)
                {
                    ar.Add(faktor);
                    brojj /= faktor;
                }
                else
                {
                    faktor++;
                }

            }
            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(ar[i]);
                if (i < ar.Count - 1)
                {
                    Console.Write("*");
                }

            }
            Console.WriteLine();





            




            Console.WriteLine("Pritisnite Enter za kraj..");
            Console.ReadLine();
        }
    }
}
