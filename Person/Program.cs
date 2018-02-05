using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opret ny 'person' p1.
            Person p1 = new Person();

            //Sæt for- og efternavn.
            p1.Fornavn = "Anders";
            p1.Efternavn = "And";

            Console.WriteLine("Fornavn   : "+p1.Fornavn);
            Console.WriteLine("Efternavn : "+p1.Efternavn);
            Console.WriteLine("Fuldt navn: " + p1.FuldtNavn());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
