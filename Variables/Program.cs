using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialiser
            Int32 heltal = 10;

            //Add 1
            heltal++;

            //Subtract 1
            heltal--;

            // Add 20
            heltal += 20;

            //Spill the beans
            Console.WriteLine("Heltal:" + heltal);

            //Initialize
            double kommatal = 12.5;

            //Add 1
            kommatal++;

            //Subtract 1
            kommatal--;

            // Multiply by 2
            kommatal *= 2;

            //Spill the beans
            Console.WriteLine("Kommatal:" + kommatal);

            //Enums
            FilTyper ft = FilTyper.csv;

            //Spill the beans
            Console.WriteLine("Filetype:" + ft);

            Console.WriteLine("Filetype (value):" + ft);

            //Dates
            DateTime dato = DateTime.Now;

            Console.WriteLine("Now is:" + dato);
            Console.WriteLine("Now is:" + dato.ToString());
            Console.WriteLine("Now is:" + dato.ToShortTimeString());
            Console.WriteLine("Now is:" + dato.ToLongDateString());

            //Structs
            Person p = new Person();
            p.Navn = "Mikkel";
            p.Id = 42;
            Console.WriteLine("Name is:" + p.Navn);
            Console.WriteLine("Id is:" + p.Id);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

}
      
    }
    enum FilTyper { csv, pdf, txt }
    //Structs
    struct Person
    {
        public string Navn;
        public int Id;
    };
}
