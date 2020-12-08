<<<<<<< HEAD
﻿using System;

using System.Collections.Generic;

=======
﻿using System;
>>>>>>> c44bac0e4d5cfe81b7c8723d9bb5f94bb401bb87

namespace _01_domaci_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1.2 - Ispis brojeva
            //Napišite program koji na konzoli ispisuje
            //brojeve 1,2,3 svaki u novi red.
            Console.WriteLine("1\n2\n3");
         

            //4.1.3 - Ledište/Vrelište
            //Napišite program koji će ispisivati temperaturu ledišta i vrelišta
            //vode, svaku u novi red
<<<<<<< HEAD
            var lediste = 0;
            int vreliste = 100;
            Console.WriteLine("Točka ledišta vode je {0} stupnjeva Celzijusa", lediste);
            Console.WriteLine("Točka vrelišta voda je {0} stupnjeva Celzijusa", vreliste);
=======
<<<<<<< HEAD
            string naslov;
            naslov = "\nLed i vatra vode";
            int led = 0;
            int vrelo = 100;
            Console.WriteLine(naslov);
            Console.WriteLine("Ledište je:" + led);
            Console.WriteLine("Vrelište je:" + vrelo);


            //5.1.1 - Zbroj i razlika
            //Program koji traži unos 2 cijela broja i prikazuje
            //na ekranu njihov zbroj te razliku
            naslov = "\nZbroj i razlika";
            Console.WriteLine(naslov);
            int Number1, Number2;
            Console.WriteLine("Unesite prvi cijeli broj:");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite drugi cijeli broj:");
            Number2 = Convert.ToInt32(Console.ReadLine());
            int Sum;
            int Razlika;
            Razlika = Number1 - Number2;
            Sum = Number1 + Number2;
            Console.WriteLine("Zbroj i razlika su {0} i {1}\n", Sum, Razlika);


            //5.1.2 - Umnožak i kvocijent
            //Program koji traži unos 2 cijela broja i prikazuje 
            //umnožak i kvocijent
            naslov = "\nUmnožak i kvocijent";
            Console.WriteLine(naslov);
            Console.WriteLine("Unesite prvi cijeli broj:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi cijeli broj:");
            int num2 = int.Parse(Console.ReadLine());
            int multi = num1*num2;
            double divis = (double) num1/num2;
            Console.WriteLine("Umnožak = " + multi);
            Console.WriteLine("Kvocijent = " + divis);
        }
    }

    
   

=======

>>>>>>> 2a06ebbbfaaba99a30fd9034a4eec1a37f230c86
            //5.1.1 - Zbroj i razlika
            //Program koji traži unos 2 cijela broja i prikazuje
            //na ekranu njihov zbroj te razliku
            int Num1, Num2 = 0;
            Console.WriteLine("Unesite 1. cijeli broj:");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite 2. cijeli broj:");
            Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj {0}", Num1 + Num2);
            Console.WriteLine("Razlika {0}", Num1 - Num2);
            //5.1.2 - Umnožak i kvocijent
            //Program koji traži unos 2 cijela broja i prikazuje 
            //umnožak i kvocijent
            int Numb1, Numb2 = 0;
            Console.WriteLine("Unesite 1. cijeli broj:");
            Numb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite 2. cijeli broj:");
            Numb2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Umnožak {0}, Kvocijent  {1}", Numb1 * Numb2, (float)Numb1 / (float)Numb2);
            Console.WriteLine("Pritisnite Enter za kraj..");
            Console.ReadLine();
        }
    }
>>>>>>> c44bac0e4d5cfe81b7c8723d9bb5f94bb401bb87
}
