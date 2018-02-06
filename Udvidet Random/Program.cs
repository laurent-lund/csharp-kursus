using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udvidet_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skab 'r' til at holde True/False fra 'UdvidetRandom'
            UdvidetRandom r = new UdvidetRandom();

            // Loop 50 gange og kalde NextBool
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(r.NextBool());
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
