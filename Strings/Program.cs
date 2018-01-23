using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inhitialize
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletNavn = fornavn + ' ' + efternavn;
            string navnStort = samletNavn.ToUpper();
            string navnLille = samletNavn.ToLower();

            int startOfString;
            startOfString = samletNavn.IndexOf('C');
            string del = samletNavn.Substring(startOfString, 4);

            string[] splitstring = samletNavn.Split(' ');

            // Spill the beans
            Console.WriteLine("Fornavn: "+fornavn);
            Console.WriteLine("Efternavn: "+efternavn);
            Console.WriteLine("Samlet navn: "+samletNavn);
            Console.WriteLine("Navn upper case: "+navnStort);
            Console.WriteLine("Navn lower case: "+navnLille);
            Console.WriteLine("Part of string: "+del);

            for (int i = 0; i < splitstring.Length; i++)
            {
                Console.WriteLine(splitstring[i]);
            }
               
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
