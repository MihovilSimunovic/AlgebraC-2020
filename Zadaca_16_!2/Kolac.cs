using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Zadaca_16__2
{
    public class Kolac
    {
        private bool kolacJeIspecen = false;
       
        private List<int> KolicinaSastojaka = new List<int>();
        private List<string> ImeSastojaka = new List<string>();

        public bool KolacJeIspecen {get => kolacJeIspecen;  set => kolacJeIspecen = value;}

        internal void DodajSastojak(string v1, int v2)
        {
            if (kolacJeIspecen == false)
            {
                KolicinaSastojaka.Add(v2);
                ImeSastojaka.Add(v1);
            }
            else
            {
                Console.WriteLine("Kolač je ispečen, NIJE dozvoljeno dodavanje sastojaka!");
            }
        }

        internal double IzracunajKolicinu()
        {
            double suma = (double)KolicinaSastojaka.Sum();
            double sumakg = (double)suma / 1000;
            return sumakg;
        }

        public override string ToString()
        {
            string rez, rez2, rez3;
            
            if (kolacJeIspecen == true)
            {
                rez = "Kolač je pečen!";
            }
            else
            {
                rez = "Kolač nije pečen.";
            }

            rez2 = "Sastojci su:" + String.Join(",", ImeSastojaka);
            rez3 = "Ukupna masa kolača je: " + IzracunajKolicinu().ToString("0.00");
            return rez + Environment.NewLine + rez2 + Environment.NewLine + rez3;
            
        }



    }
}