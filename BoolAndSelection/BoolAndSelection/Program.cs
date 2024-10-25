using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoolAndSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            //0. Kérj be egy magasságot cm-ben.
            //Írd ki, hogy ennyi cm hány méter
            //Console.WriteLine("Add meg, hány cm vagy!");
            //double cm = double.Parse(Console.ReadLine());
            //Console.WriteLine($"Méterben: {cm / 100}");

            //1. Logikai változó

            /*bool b1 = true;
            bool b2 = false;
                           //  double    (int / int --> int)     
            Console.WriteLine(1.5 * (4 / 3)); //--> 1.5
            Console.WriteLine(1.5 * (7 / 3));   //--> 3

            Console.WriteLine(b1 && b2);    //és
            Console.WriteLine(b1 || b2);    //vagy

            Console.WriteLine(b1 == false && b2 == true);
            Console.WriteLine(b1 == true && b2 == true);
            Console.WriteLine(b1 == false && b2 == false);
            Console.WriteLine(b1 == true && b2 == false);

            Console.WriteLine(b1 == false || b2 == true);
            Console.WriteLine(b1 == true || b2 == true);
            Console.WriteLine(b1 == false || b2 == false);
            Console.WriteLine(b1 == true || b2 == false);

            Console.WriteLine(!b1);
            Console.WriteLine(!b2);*/


            /*Console.WriteLine("Add meg milyen magas vagy (cm): ");
            double m = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg hany kg vagy: ");
            double kg = double.Parse(Console.ReadLine());
            m = m / 100;
            Console.WriteLine($"Testömeg index: {kg/(m*m)}");

            Console.WriteLine(1.5*((double)3/2));

            //4. If-then-else elágazás

            int x = 10;

            if (x == 10)
            {
                Console.WriteLine("x értéke 10");
            }

            x = 11;

            if (x == 10)
            {
                Console.WriteLine("x értéke 10");
            }
            else
            {
                Console.WriteLine("x értéke nem 10");
            }


            if(x == 10){
                Console.WriteLine("x értéke 10");
            }
            if(x != 10)
            {
                Console.WriteLine("x értéke nem 10");
            }

            if (x == 10)
            {
                Console.WriteLine("x értéke 10");
            }
            else if (x == 11)
            {
                Console.WriteLine("x értéke 11");
            }
            else
            {
                Console.WriteLine("x értéke nem 10");
            }

            x = 21;
            int y = 10;
            if(x == 21)
            {
                if(y == 10)
                {
                    Console.WriteLine("x egyenlő 21-el, y egyenlő 10-el");
                }
            }

            if(x == 21 && y == 10)
            {
                Console.WriteLine("x egyenlő 21-el, y egyenlő 10-el");
            }

            //?:
            
           
            

            Console.WriteLine("Add meg hány literes a tank: ");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("Add meg mennyit fogyaszt km-ként: ");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine($"Az autó egy tankkal kb. {(l / km)} km-t tesz meg.");
            
            Console.WriteLine(5/6);     //0.83333 ez helyett 0 lesz
            Console.WriteLine((double)5/6);     //0.83333 ez helyett 0 lesz
            Console.WriteLine(3.33 * ((double)5/6));
            */

            int x = 22;
            Console.WriteLine(x == 21 ? "Az x 21" : "Az x nem 21");
            Console.WriteLine(x == 21 ? "Az x 21" : x > 22 ? "Az x nagyobb, mint 21" : "Az x kisebb, mint 21");


            Console.Write("Adj meg egy magánhangzót: ");
            string betu = Console.ReadLine();

            switch (betu)
            {
                case("A"):
                case("a"):
                    Console.WriteLine("Ez egy a");
                    break;
                case("e"):
                    Console.WriteLine("Ez egy e");
                    break;
                case("i"):
                    Console.WriteLine("Ez egy i");
                    break;
                case("o"):
                    Console.WriteLine("Ez egy o");
                    break;
                case("u"):
                    Console.WriteLine("Ez egy u");
                    break;
                default:
                    Console.WriteLine("Ez nem magánhangzó");
                    break;

            }









            Console.ReadKey();
        }
    }
}
