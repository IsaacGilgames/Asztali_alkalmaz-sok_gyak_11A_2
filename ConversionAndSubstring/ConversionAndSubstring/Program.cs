using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionAndSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Szoftverfejlesztés";
            string str2 = str.Substring(8, 3);
            Console.WriteLine(str2);

            //Mit ír ki, ha a Substring(4, 4)
            string str3 = str.Substring(4, 4);
            Console.WriteLine(str3);


            //Hogy íratassuk ki azt, hogy "ejleszt"?
            Console.WriteLine(str.Substring(9, 7));


            //1. Implicit típus konverzió
            Console.WriteLine("\n\n\n\n");
            int numInt = 500;
            Type n = numInt.GetType();

            Console.WriteLine(numInt);
            Console.WriteLine(n);

            double numDouble = numInt;
            Type n1 = numDouble.GetType();

            Console.WriteLine(numDouble);
            Console.WriteLine(n1);

            //2. Castolás
            int szam1 = 5;
            int szam2 = 120;
            double maradeknincs = szam1 / szam2;
            double vanmaradek1 = Convert.ToDouble(szam1) / szam2; //konvertálás
            double vanmaradek2 = (double)szam1 / szam2; //castolás
            Console.WriteLine("\n\nMi történik: " + vanmaradek1);


            //Explicit típus konverzió
            numDouble = 3.14;

            numInt = (int)numDouble; // double --> int
            //numInt = Convert.ToInt32(numDouble);

            Console.WriteLine(numDouble);
            Console.WriteLine(numInt);



            Console.ReadKey();




        }
    }
}
