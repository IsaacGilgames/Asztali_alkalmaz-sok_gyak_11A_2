using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak1024
{
    class Program
    {
        //Gyak1024
        static void Main(string[] args)
        {
            //Összes szám kiírása 1-100
            //ami osztható 3-mal
            //de nerm osztható 9-cel

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 9 != 0)
                {
                    Console.WriteLine(i);
                }
            }



            //-100-tól 100-ig írjátok ki
            //egymás mellé a számokat
            //a negatív-pozitív párok legyenek egymás
            //mellett pl -23 és 23

            for (int i = 0; i <= 100; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine($"{i, 4} és {-i, 4}");
                }
            }

            Console.ReadKey();
        }
    }
}
