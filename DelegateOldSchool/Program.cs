using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOldSchool
{
    public delegate int beregnoldschool(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            // Old school.
            Console.WriteLine("Old school math");
            int resdivi = BeregnerOldSchool(2, 3, divider);
            Console.WriteLine("2/3 = "+resdivi);

            int resdivi2 = BeregnerOldSchool(3, 2, divider);
            Console.WriteLine("3/2 = " + resdivi2);

            int resmulti = BeregnerOldSchool(2, 3, Multiplicer);
            Console.WriteLine("2*3 = " + resmulti);

            int resadd = BeregnerOldSchool(2, 3, Adder);
            Console.WriteLine("2+3 = " + resadd);

            int ressub = BeregnerOldSchool(2, 3, Subtraher);
            Console.WriteLine("2-3 = " + ressub);
            Console.WriteLine();


            // New school.
            Console.WriteLine("New school math");
            int resdivinew = BeregnerNewSchool(2, 3, divider);
            Console.WriteLine("2/3 = " + resdivi);

            int resdivinew2 = BeregnerNewSchool(3, 2, divider);
            Console.WriteLine("3/2 = " + resdivi2);

            int resmultinew = BeregnerNewSchool(2, 3, Multiplicer);
            Console.WriteLine("2*3 = " + resmulti);

            int resaddnew = BeregnerNewSchool(2, 3, Adder);
            Console.WriteLine("2+3 = " + resadd);

            int ressubnew = BeregnerNewSchool(2, 3, Subtraher);
            Console.WriteLine("2-3 = " + ressub);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        // De fire regnearter for heltal.
        public static int Adder(int a, int b)
        {
            return a + b;
        }

        public static int Subtraher(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicer(int a, int b)
        {
            return a * b;
        }

        public static int divider(int a, int b)
        {
            return a / b;
        }

        // Beregner Old school.
        public static int BeregnerOldSchool(int x, int y, beregnoldschool funcoldschool)
        {
            return funcoldschool(x, y);
        }

        // New school.
        public static int BeregnerNewSchool(int x, int y, Func<int, int, int> funcnewschool)
        {
            return funcnewschool(x, y);
        }
        
    }
}
