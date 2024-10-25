using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak_elag_ciklus
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Számológép: ");

            Console.Write("Első szám: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Írd be a müveletet(+, -, *, /): ");
            string muvelet = Console.ReadLine();

            Console.Write("Második szám: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Az általad megadott művelet: {a}{muvelet}{b}");
            double er = 0;
            bool helyes = true;
            switch (muvelet)
            {
                case "+":
                    er = a + b;
                    break;
                case "-":
                    er = a - b;
                    break;
                case "*":
                    er = a * b;
                    break;
                case "/":
                    er = a/b;
                    break;
                default:
                    helyes = false;
                    break;
            }

            if (helyes)
            {
                Console.WriteLine($"Az eredmény: {er}");
            }
            else
            {
                Console.WriteLine("Nem az általam megadott műveletek közül választottál");
            }
            */

            for (int i = 1; i < 10;i++)
			{
                for (int j = 0; j < 10; j++)
			{
                    Console.WriteLine($"{i}{j}{i}");
			}
			}

            string szam = "";
            for(int x = 100; x <= 999; x++) { 
                szam += x;
                if(szam[0] == szam[2]) { 
                    Console.WriteLine(szam);
                }
                szam = "";
            }


            Console.ReadKey();



        }
    }
}
