using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StingAndGyak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg a téglalap egyik oldalát: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Add meg a téglalap másik oldalát: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Kerület: " + 2 * (a + b) + " Területe: "
                + a * b);

            //1. String definiálása és deklarálása
            string firstString = "Ez egy string";
            Console.WriteLine(firstString);

            //2. Escape karakterek
            Console.WriteLine("Első sor.\nMásodik sor.");       // \n sortörés
            Console.WriteLine("Tabulátor előtt.\tTabulátor után.");  // \t vízszintes tabulátor
            Console.WriteLine("\"Ez egy idézet\"");
            Console.WriteLine("\\\\HBSZF03");
            Console.WriteLine("\a"); //alert hang

            //3. Verbatim string
            Console.WriteLine(@"
                    Első sor.
                    Második sor."); //sortörés és tab
            Console.WriteLine(@"""Ez egy idézet.""");
            Console.WriteLine(@"\\HBSZF03");

            //4. String konkatenáció
            string iskola = "HBSZ";
            int ev = 2024;

            Console.WriteLine("A tanévnyitó " + ev + ". szept. 2-án volt a " +
                iskola + "-ben");

            //5. String interpoláció
            Console.WriteLine($"A tanévnyitó {ev}. szept. 2-án volt a {iskola}-ben");

            //6. Kompozit formázás
            Console.WriteLine("A tanévnyitó {0}. szept. 2-án volt a {1}-ben", ev, iskola);




            Console.ReadKey();
        }
    }
}
