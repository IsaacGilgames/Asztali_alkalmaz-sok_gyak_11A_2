using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaziFeladatMegoldasok
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 2 == 0 && i % 8 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            int x = 1;
            Console.Write("Adj meg egy számot: ");
            int num = int.Parse(Console.ReadLine());
            for(int i = num; i > 1; i--)
            {
                if(i-1 == 1)
                {
                    x *= i;
                    Console.WriteLine($"{num}! = {x}");
                }
                else
                {
                    x *= i;
                    Console.WriteLine($"{num}! = {x} * {i - 1}!");
                }
                
            }

            string helyes = "qwertz";
            string jelszo = "";
            bool logikai = true;
            while (logikai)
            {
                Console.WriteLine("Add meg a helyes jelszót:");
                jelszo = Console.ReadLine();
                if (helyes == jelszo)
                {
                    logikai = false;
                }
                
            }
            Console.WriteLine("A helyes jelszó: " + jelszo);



            int honap = int.Parse(Console.ReadLine());

            switch (honap)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    Console.WriteLine("31 nap");
                    break;
                case 2:
                    Console.WriteLine("28 vagy 29 nap");
                    break;
                case 4:
                case 6:
                case 9:
                case 12:
                    Console.WriteLine("30 nap");
                    break;
                default:
                    Console.WriteLine("Olyat adtál meg, ami nincs");
                    break;
            }

            //100-90 5
            //89-70 4
            //69-50 3
            //49-30 2
            //29-0 1

            //Egész számot kérsz be!!!!!
            Console.Write("Add meg hány százalékos lett a dolgozat eredménye (kerekítve):");
            int eredmeny = int.Parse(Console.ReadLine());
            if(eredmeny >= 90)
            {
                Console.WriteLine("Ötös");

            }
            else if(eredmeny >= 70)
            {
                Console.WriteLine("Négyes");
            }
            else if (eredmeny >= 50)
            {
                Console.WriteLine("Hármas");
            }
            else if (eredmeny >= 30)
            {
                Console.WriteLine("Kettes");
            }
            else if (eredmeny >= 0)
            {
                Console.WriteLine("Egyes");
            }
            else
            {
                Console.WriteLine("Nem jó értéket írtál be!");
            }






            Console.ReadKey();

        }
    }
}
