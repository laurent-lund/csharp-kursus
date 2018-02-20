using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionKort
{
    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }

        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }

        public class Bunke
        {
            // Opret en stak der kan holde Kort.
            private Stack<Kort> bunke = new Stack<Kort>();

            // Metode til at lægge et kort på stakken.
            public void TilføjKort(Kort k)
            {
                bunke.Push(k);
            }

            // Metode til at fjerne øverste kort fra stakken.
            public Kort FjernKort()
            {
                // Hvis der er kort på stakken, returner øverste
                if (bunke.Count > 0)
                    return bunke.Pop();
                // ellers returner null.
                return null;
            }

            // Metode til at vise de kort der ligger på stakken.
            public void visStak()
            {
                foreach (var kort in bunke)
                {
                    Console.WriteLine(kort);
                }
            }
        }
    }
}

