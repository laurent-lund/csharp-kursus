using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeregnArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            Console.WriteLine("Unsorted array: " + string.Join(" ", test));
            var res = BeregnOgSorterArray(ref test);
            Console.WriteLine("Sorted array" + string.Join(" ", test));
            Console.WriteLine("Sum: " + res.sum);
            Console.WriteLine("Gennemsnit: " + res.gennemsnit);


            ArrayResultat BeregnOgSorterArray(ref int[] testarray)
            {
                ArrayResultat result;

                // Beregn sum
                double sum = 0;
                for (int i = 0; i < testarray.Length; i++)
                {
                    sum += Convert.ToDouble(testarray[i]);
                }

                // Beregn gennemsnit
                double gennemsnit = 0.0;
                gennemsnit = sum / testarray.Length;

                result.sum = sum;
                result.gennemsnit = gennemsnit;

                // sort the array.
                Array.Sort(testarray);

                return result;
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
        struct ArrayResultat
        {
            public double sum;
            public double gennemsnit;
        }
    }
}
