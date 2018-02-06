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
            // Del 1 - Person

            //Opret ny 'person' p1.
            Person p1 = new Person();

            //Sæt for- og efternavn.
            p1.Fornavn = "Anders";
            p1.Efternavn = "And";

            Console.WriteLine("Fornavn   : "+p1.Fornavn);
            Console.WriteLine("Efternavn : "+p1.Efternavn);
            Console.WriteLine("Fuldt navn: " + p1.FuldtNavn());


            // Del 2 - Arv
            Elev e = new Elev();
            e.Fornavn = "Frodo";
            e.Efternavn = "Baggins";
            e.Klasselokale = "42";
            

            Console.WriteLine();
            Console.WriteLine("Elev:");
            Console.WriteLine("Fornavn   : " + e.Fornavn);
            Console.WriteLine("Efternavn : " + e.Efternavn);
            Console.WriteLine("Fuldt navn: " + e.FuldtNavn());

            Instruktør i = new Instruktør();
            i.Fornavn = "Gandalf";
            i.Efternavn = "Grey";
            i.Nøgleid = 42;

            Console.WriteLine();
            Console.WriteLine("Instruktør:");
            Console.WriteLine("Fornavn   : " + i.Fornavn);
            Console.WriteLine("Efternavn : " + i.Efternavn);
            Console.WriteLine("Fuldt navn: " + i.FuldtNavn());


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
