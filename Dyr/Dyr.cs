using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udvidet_Random;
using System.IO;

namespace Dyr
{
    class Dyr
    {
        // Skab 'r' til at holde True/False fra 'UdvidetRandom'
        private static UdvidetRandom r = new UdvidetRandom();

        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr, og hedder " + Navn + '.');
        }

        public static Dyr TilfældigtDyr()
        {
            // Læs fil med dyrenavne.
            string sti = @"x:\dyrenavne.txt";
            string[] dyrenavne = File.ReadAllLines(sti);

            if (r.NextBool())
            {
                return new Hund() { Navn = dyrenavne[r.Next(0, dyrenavne.Length)] };
            }
            else
            {
                return new Kat() { Navn = dyrenavne[r.Next(0, dyrenavne.Length)] };
            }
        }
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund, og hedder " + Navn + '.');
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat, og hedder " + Navn + '.');
        }
    }
}
