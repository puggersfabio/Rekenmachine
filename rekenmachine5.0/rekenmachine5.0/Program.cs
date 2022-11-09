using System;
using System.Collections.Generic;


namespace rekenmachine5._0
{
    class Program
    {
        /* de list waar alle cijfers in gaan */
        static List<double> lijst = new List<double>();
        static void Main()
        {
            Console.WriteLine("Welkom bij de c# rekenmachine");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Voer alle getallen in: ");
            Getallen();

         static void Getallen()
            {                
            string invoer = Console.ReadLine();
            double result; 

                /* functie dat zorgt dat als je alle getallen invult het menu opent */
            if(invoer == "")
            {
                keuze(); 
            }
            else
            {
                    /* kijkt als er een getal/getallen ingevoerd */
                if(double.TryParse(invoer, out result)){
                    lijst.Add(result);
                    Getallen();
                }
                /* als er geen getallen worden ingevuld */
                else
                {
                    Console.WriteLine("voer A.U.B getallen in!");
                    Getallen();
                }                  
            }
         }

            

        }
        static void keuze()
        {
            /* het menu */
            Console.WriteLine("Type 1 voor een som");
            Console.WriteLine("Type 2 om het maximum te bereken");
            Console.WriteLine("Type 3 om het minimum");
            Console.WriteLine("Type 4 om het gemiddelde te bereken");

            string Keuze2 = Console.ReadLine();
            if (Keuze2 == "1")
            {
                /* telt alle cijfers in de lijst bij elkaar op */
                double resultaat = 0;
                for (int n = 0; n < lijst.Count; n++)
                {
                    resultaat = resultaat + lijst[n];
                }
                Console.WriteLine("het antwoord is: " + resultaat);
                opnieuw();

            }
            else if (Keuze2 == "2")
            {
                double resultaat = lijst[0];
                /* berekent het maximale van de cijfers in het lijst */
                for (int n = 0; n < lijst.Count; n++)
                {
                    if(resultaat > lijst[n])
                    {
                        resultaat = resultaat; 
                    }
                    if(resultaat < lijst[n])
                    {
                        resultaat = lijst[n];
                    }
                    if(resultaat == lijst[n])
                    {
                        resultaat = resultaat;
                    }
                }
                Console.WriteLine("Het grootste getal is: " + resultaat);
                opnieuw();
            }
            else if (Keuze2 == "3")
            {
                double resultaat = lijst[0];
                /* berekent het laagste van de cijfers in het lijst */
                for (int n = 0; n < lijst.Count; n++)
                {
                    if (resultaat < lijst[n])
                    {
                        resultaat = resultaat;
                    }
                    if (resultaat > lijst[n])
                    {
                        resultaat = lijst[n];
                    }
                    if (resultaat == lijst[n])
                    {
                        resultaat = resultaat;
                    }
                }
                Console.WriteLine("Het kleinste getal is: " + resultaat);
                opnieuw();
            }
            else if (Keuze2 == "4")
            {
                /* telt eerst alle cijfers op en deeld ze dan door de aantal in het lijstje */
                double resultaat = 0;
                for (int n = 0; n < lijst.Count; n++)
                {
                    resultaat = resultaat + lijst[n];
                }
                resultaat = resultaat / lijst.Count;
                Console.WriteLine("het antwoord is: " + resultaat);
            }
            else 
            {
                /* komt als je niet 1 van de keuzes neemt in het menu */
                Console.WriteLine("kies 1 van de boven staande keuzes A.U.B.");
            }
            opnieuw();
        }
        static void opnieuw()
        {
            /* als je klaar bent met berekenen en u wilt nog een x komt deze functie */
            Console.WriteLine("wilt u nog een berekening type 1!");
            Console.WriteLine("hoeft geen berekeningen meer type 2!");
            string Keuze3 = Console.ReadLine();

            if (Keuze3 == "1")
            {
                Main();
                lijst.Clear();
            }
            if (Keuze3 == "2")
            {
                Console.WriteLine("tot ziens");
            }

        }

    }
}






