using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dyr
{
    class Program
    {
        static void Main(string[] args)
        {       
            // Lav et array af dyrepointere der peger på 20 dyr.
            Dyr[] dyr = new Dyr[20];

            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item.SigNoget();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
