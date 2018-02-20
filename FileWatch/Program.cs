using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reager på ændringer af filer af typen *.txt i "C:\temp\".
            FileSystemWatcher w = new FileSystemWatcher(@"c:\temp","*.txt");

            // Sæt igang med at lytte.
            w.EnableRaisingEvents = true;

            // Filtrering så vi ikke spammes af hændelser.
            w.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite;
            //w.NotifyFilter = NotifyFilters.FileName | NotifyFilters.Size;

            // Tilføj 'changed' delegate
            w.Changed += W_Changed;

            // Endless Endless...
            do { } while (true);
      
        }

        private static void W_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Text filen "+ e.Name+ " rettet.");
        }
    }
}
