using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep_aukcyjny
{
    public class Baza
    {
        internal static void WyswietlListedostepu(string nazwa1, string nazwa2, decimal cena, string numerKarty)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"KUPIŁEŚ PRZEDMIOT: {nazwa2} ");
            Console.WriteLine($"CENA: {cena} PLN");
            Console.WriteLine($"PŁATNOŚĆ KARTĄ: {nazwa1} (NR KARTY: {numerKarty}) ");
            Console.WriteLine("ZAKUP OPŁACONY.");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }

}
