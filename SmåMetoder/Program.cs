using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmåMetoder
{
    class Program
    {
        static void Main(string[] args)
        {




            // Method definitions
            int LægSammen(int a, int b)
            {
                return a + b;
            }

            double BeregnAreal(int radius)
            {
                return (3.14159265358979323846) * radius * radius;
            }

            void Udskriv(string txt)
            {
                Console.WriteLine(txt);
            }

            double Gennemsnit(int[] månedsløn)
            {
                int total = 0;

                for (int i = 0; i < månedsløn.Length; i++)
                {
                    total += månedsløn[i];
                }
                return total / månedsløn.Length;
            }


            int res = LægSammen(5, 2);
            Console.WriteLine(res);         //7

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);        // 78,53...

            Udskriv("Dette er en test");    // Dette er en test

            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);         // 15.000


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
