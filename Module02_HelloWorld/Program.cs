using System;

namespace Module02_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.Write('H');
            Console.Write('e');
            Console.Write('l');
            Console.Write('l');
            Console.Write('o');
            Console.Write(' ');
            Console.Write('W');
            Console.Write('o');
            Console.Write('r');
            Console.Write('l');
            Console.Write('d');
            Console.WriteLine('!');

            Console.ForegroundColor = ConsoleColor.Cyan;

            String HW = "Hello world.";
            int length;

            length = HW.Length;
                Random rand = new Random();

            for (int i = 0; i < HW.Length; i++)
            {
                int farve;
                farve = rand.Next(11);
                Console.ForegroundColor = (System.ConsoleColor)farve;
                Console.Write(HW[i]);
            }



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        static void DebugDemo()
        {

            int i = 10;
            int u = 20;
            u = u + i;
            string name = "Mikkel";
            System.Console.WriteLine(name);
            string upperName = name.ToUpper();
            System.Console.WriteLine(upperName);

            for (int x = 0; x < 3; x++)
            {
                u += x;
            }

            Test1(5);

        }

        static void Test1(int i)
        {
            i++;
            Test2(i);
        }

        static void Test2(int i)
        {
            i--;
            Test3(i);
        }

        static void Test3(int i)
        {
            i++;
        }
    }
}
