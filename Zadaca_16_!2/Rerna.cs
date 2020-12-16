using System;

namespace Zadaca_16__2
{
    static class Rerna
    {
        internal static int BrojIspecenihKolaca;

        public static void Ispeci(ref Kolac k1)
        {
            k1.KolacJeIspecen = true;
            BrojIspecenihKolaca += 1;

        }
    }
}