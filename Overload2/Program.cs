using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload2
{
    class Program
    {
        static int Beregn(int arg1, int arg2)
        {
            return arg1 + arg2;
        }

        static int Beregn(int arg1, int arg2, int arg3)
        {
            return arg1 + arg2 + arg3;
        }

        static int Beregn(int arg1, int arg2, int arg3, int arg4)
        {
            return arg1 + arg2 + arg3 + arg4;
        }


        static void Main(string[] args)
        {

            Console.WriteLine(Beregn(1,2));
            Console.WriteLine(Beregn(1,2,3));
            Console.WriteLine(Beregn(1,2,3,4));



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
