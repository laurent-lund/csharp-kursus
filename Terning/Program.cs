using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opret ny terning, og lad t1 pege på den.
            Terning t1 = new Terning();

            // Ryst t1 og vis resultatet.
            t1.Ryst();
            t1.Skriv();

            // Opret ny terning, der som udgangspunkt viser fire.
            Terning t2 = new Terning(4);

            // Vis terningen, og se det er korrekt at der er fire øjne.
            t2.Skriv();

        



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
