using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vareklasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opret vare
            Vare v1 = new Vare();

            // Tildel navn
            v1.Navn = "Frosties";

            // Tildel pris
            v1.Pris = 20.0;

            // Udskriv navn
            Console.WriteLine(v1.Navn);

            // Udskriv pris
            Console.WriteLine(v1.Pris);

            // Udskriv pris incl. Moms.
            Console.WriteLine("Pris incl. Moms: "+PrisMedMoms());

             double PrisMedMoms()
            {
                return 1.25 * v1.Pris;
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    public class Vare
    {
        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine("Navn læst.");
                return navn; }
            set {
                Console.WriteLine("Navn sat.");
                navn = value; }
        }

        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine("Pris læst.");
                return pris; }

            set {
                Console.WriteLine("Pris sat.");
                pris = value; }
        }
    }
}
