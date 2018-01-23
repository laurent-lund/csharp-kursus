using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_and_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            int ncols = 10;
            int nrows = 10;
            int colourchangevalue = 50;
            int value;
            string valuestr;

            for (int row = 0; row < nrows; row++)
            {
                for (int col = 0; col < ncols; col++)
                {
                    //value = row * ncols + col + 1;
                    value = (row+1) * (col + 1);

                    // Determine colour
                    if (value > colourchangevalue)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }

                    Console.Write("" + value.ToString("G").PadLeft(4));
                    //valuestr = string.Format("{1,5,N1}", value);
                }
                Console.WriteLine();
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
