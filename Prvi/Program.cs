﻿using System;

namespace Prvi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Evo dopunio sam!");
            Automobil a1 = new Automobil();
            Console.WriteLine(a1);
            a1.boja = "Mar\"oon";
            Console.WriteLine(a1);
            
            a1.PostaviSnagu(100);
            Console.WriteLine(a1);
            

        }
    }
}
namespace SecondNamespace
{
    class Program
    {
        public void Tester(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

}
