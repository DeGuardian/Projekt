using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep_aukcyjny
{
    public class KartaKredytowa
    {
        public KartaKredytowa(string nazwa, string numer, decimal limit)
        {
            Nazwa = nazwa;
            NumerKarty = numer;
            Limit = limit;

        }



        public string Nazwa { get; set; }
        public string NumerKarty { get; set; }
        public decimal Limit { get; set; }




        public override string ToString()
        {
            return $" {Nazwa} {NumerKarty} ";

        }
    }

}
