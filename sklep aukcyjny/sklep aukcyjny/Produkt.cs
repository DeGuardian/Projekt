using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep_aukcyjny
{
    public class Produkt
    {
        public Produkt(int id, string nazwa, string kategoria , decimal cena , bool czyWyrozniony)
        {
            Id = id;
            Nazwa = nazwa;
            Kategoria = kategoria;
            Cena = cena;
            CzyWyrozniony = czyWyrozniony;

        }
        
        
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Kategoria { get; set; }
        public decimal Cena { get; set; }
        public bool CzyWyrozniony { get; set; }

        public override string ToString()
        {
            return $"  {Nazwa} {Cena} ";
            
        }
    }

}

