using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] kennel = new Hund[2];
            kennel[0] = new Hund { Alder = 6, Navn = "Siena" };
            kennel[1] = new Hund { Alder = 5, Navn = "Brutus" };

            foreach (var hund in kennel)
            {
                Console.WriteLine(hund.Navn);
            }

            // Vil ikke virke til der er noget 'IComparable'
            // eftersom maskinen ikke ved hvad der skal sorteres efter.
            Array.Sort(kennel);

            foreach (var hund in kennel)
            {
                Console.WriteLine(hund.Navn);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        class Hund : IComparable
        {
            public int Alder { get; set; }
            public String Navn{ get; set; }

            // Objekt Hund implementerer interface IComparable
            // så der skal vær en CompareTo metode.
            public int CompareTo(object obj)
            {
                Hund h = obj as Hund;

                return Math.Sign(this.Alder - h.Alder);

                //if (h.Alder > this.Alder)
                //{
                //    return -1;
                //}
                //if (h.Alder < this.Alder)
                //{
                //    return 1;
                //}
                //return 0;
            }

        }
    }
}
