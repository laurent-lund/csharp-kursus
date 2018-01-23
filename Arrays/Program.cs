using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string nmonthsstr;
            int nmonths;
            int total=0;
            int msalary;
            double averagesalary=0;
            Random rand = new Random();

            Console.Write("Antal månedslønninger: ");

            nmonthsstr = Console.ReadLine();
            nmonths = Convert.ToInt16(nmonthsstr);

            Console.WriteLine();

            for (int i = 0; i < nmonths; i++)
            {
                msalary = rand.Next(54000, 65000);
                Console.Write("Måned nummmer:\t"+(i+1));
                Console.WriteLine(" : " +msalary);
                total += msalary;
            }

            Console.WriteLine("Total løn er:       "+total);
            Console.WriteLine("");

            averagesalary = total / nmonths;

            Console.WriteLine("Gennemsnitsløn:    "+averagesalary);



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
}
