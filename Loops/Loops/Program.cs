using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //1. For ciklus - Számláló ciklus
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //int i = 10; -> Hiba

            Console.WriteLine();

            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //i < 10 && i != 4
            for (int i = 0; i < 10 && i != 4; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //2. while ciklus - Előltesztelős ciklus
            int j = 0;

            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine();

            //3. Hátultesztelős Do - While
            j = 0;
            do
            {
                Console.WriteLine(j++);
            } while (j < 10);
            
            Console.WriteLine();

            //4. Foreach ciklus

            string text = "abcdefghijklmnopqrstuvwxyz";

            
            foreach(char ch in text)
            {
                Console.WriteLine(ch);
            }

            for(int i = 1; i <= 3; i++)
            {
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            int szam = int.Parse(Console.ReadLine());
            Console.Write("+");
            for(int i = 1; i <= szam;i++)
            {
                Console.Write("-");
            }
            Console.Write("+");

            
            //Primszám-e?
            Console.Write("\nAdj meg egy számot:");
            int number = int.Parse(Console.ReadLine());
            bool prim = true;
            
            for(int i = 2; i < number; i++)
            {
                //Console.WriteLine(i);
                if (number % i == 0)
                {
                    prim = false;
                }
            }
            if (prim)
            {
                Console.WriteLine($"A {number} primszám");
            }
            else {
                Console.WriteLine($"A {number} nem primszám");
            }
            
            int n0 = 0;
            int n1 = 1;
            int temp = 0;
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(n0);
                temp = n0;
                n0 = n1;
                n1 = temp + n1;
            }
            */
            Console.WriteLine("Szám: ");
            int szam = int.Parse(Console.ReadLine());

            int oszto;
            oszto = 2;

            while(szam > 1)
            {
                if(szam % oszto == 0)
                {
                    Console.Write($"{szam, 5}|{oszto}\n");
                    szam /= oszto;
                }
                else
                {
                    oszto++;
                }
            }
            Console.Write($"{szam,5}|1\n");











            Console.ReadKey();
        }
    }
}
