using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Using
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"x:\dyrenavne.txt";

            // File read UDEN 'Using'.
            Console.WriteLine("File read uden Using.");
            StreamReader stream = System.IO.File.OpenText(filepath);
            while (stream.Peek() != -1)
            {
                string navn = stream.ReadLine();
                Console.WriteLine(navn);
            }
            stream.Close();
            stream = null;
            Console.WriteLine("");

            // File read MED 'Using'.
            // Den korrekte måde at gøre 'det' på!
            Console.WriteLine("File read med Using.");
            using (StreamReader sr = File.OpenText(filepath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
