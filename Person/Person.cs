using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        //Automatisk egenskab - prop+TAB
        public string Fornavn { get; set; }

        //Fuld egenskab - propfull+TAB
        private string efternavn;
        public string Efternavn
        {
            get { return efternavn; }
            set { efternavn = value; }
        }

        // Ingen egenskab
        public string FuldtNavn()
        {
            return Fornavn + ' ' + Efternavn;
        }
    }

    public class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    public class Instruktør : Person
    {
        public int Nøgleid { get; set; }

    }
}
