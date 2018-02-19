using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgetInterface
{

    public interface IDbMetoder
    {
        void Gem();
    }
    class Program
    {
        static void Main(string[] args)
        {

            IDbMetoder[] mysticArray = new IDbMetoder[10];

            mysticArray[0] = new EgetInterfaceHund();
            mysticArray[1] = new EgetInterfaceUbåd();
            mysticArray[2] = new EgetInterfaceHund();
            mysticArray[3] = new EgetInterfaceUbåd();
            mysticArray[4] = new EgetInterfaceHund();
            mysticArray[5] = new EgetInterfaceUbåd();
            mysticArray[6] = new EgetInterfaceHund();
            mysticArray[7] = new EgetInterfaceUbåd();
            mysticArray[8] = new EgetInterfaceHund();
            mysticArray[9] = new EgetInterfaceUbåd();

            foreach (var item in mysticArray)
            {
                item.Gem();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
