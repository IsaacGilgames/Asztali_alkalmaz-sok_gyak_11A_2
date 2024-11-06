using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuggvenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérek egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine(Faktorialis(szam));

            Console.Write("Kérem a kör sugarát: ");
            double r = 0;
            Beker(ref r);
            
            Console.WriteLine("A kör kerülete: {0} és Területe: {1}" 
                , Kerulet(r),Terulet(r));

            Console.ReadKey();
        }

        static int Faktorialis(int sz)
        {
            int fakt = 1;
            for (int i = 2; i <= sz; i++)
            {
                fakt *= i;
            }
            return fakt;
        }

        static void Beker(ref double r)
        {
            r = double.Parse(Console.ReadLine());

            
        }
        static double Kerulet(double r)
        {
            double k = r * 2 * Math.PI;
            return k;
        }
        static double Terulet(double r)
        {
            double t = Math.Pow(r,2) * Math.PI;
            return t;
        }




    }
}
