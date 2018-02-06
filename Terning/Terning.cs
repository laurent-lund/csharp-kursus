using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Terning
    {
        private int værdi;
        private static System.Random rnd = new Random();

        // Constructor - Terning rystes når den skabes.
        public Terning()
        {
            this.Ryst();
        }

        public Terning(int antaløjne)
        {
            this.værdi = antaløjne;
        }


        public int Værdi
        {
            get { return værdi; }
            set
            {
                if (1 > value)
                {
                    værdi = 1;
                }
                else if (value > 6)
                {
                    værdi = 6;
                }
                else
                {
                    værdi = value;
                }
            }
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(7);
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + værdi + "]");
        }
    }

    class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            return (this.Værdi == 3);
        }

        public bool ErStjerne()
        {
            return (this.Værdi == 5);
        }

    }
}
