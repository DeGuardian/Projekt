using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep_aukcyjny
{
    public class Portal
    {
        public Portal()
        {
            UtworzProduktyiKarty();
        }

        private void UtworzProduktyiKarty()

        {
            Produkty.Add(new Produkt(1, "Bluza Adidas Męska Szara", "odzież", 249m, true));
            Produkty.Add(new Produkt(2, "iPhone 12 Pro", "elektronika", 4600m, true));
            Produkty.Add(new Produkt(3, "Konsola Playstation 5", "elektronika", 2899m, false));
            Produkty.Add(new Produkt( 4, "Spodnie Wrangler Arizona", "odzież", 189m, false));
            Produkty.Add(new Produkt( 5, "Basen ogrodowy Premium", "dom i ogród", 1199m, false));
            Produkty.Add(new Produkt( 6, "Krzesło skandynwskie granatowe", "dom i ogród", 88m, false));
            Karty.Add(new KartaKredytowa("Visa", "0001", 100m));
            Karty.Add(new KartaKredytowa("Mastercard", "0002", 10000m));
            Karty.Add(new KartaKredytowa("American Express", "0003", 3000m));
            Karty.Add(new KartaKredytowa("Diners Club", "0004", 1000m));
        }

        public List<Produkt> Produkty { get; set; } = new List<Produkt>();
        public List<KartaKredytowa> Karty { get; set; } = new List<KartaKredytowa>();

       
    }
}