using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyak1007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Évszám: ");
            int year = int.Parse(Console.ReadLine());
            if(((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("Szökőév");
            }
            else
            {
                Console.WriteLine("Normális év");
            }





            Console.ReadKey();

        }
    }
}
