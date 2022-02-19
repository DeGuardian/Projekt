using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sklep_aukcyjny
{
    public class Ekran
    {
       

        internal static string PokazMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Witamy w Sklepie Aukcyjnym");
            Console.WriteLine();
            Console.WriteLine("Wybierz Opcje:");
            Console.WriteLine("1 ==> Zakupy");
            Console.WriteLine("2 ==> Sprzedaż");
            Console.WriteLine("3 ==> Zakończyć program");
            Console.WriteLine("Wybierz 1, 2 lub 3");
            Console.WriteLine();
            return Console.ReadLine();
            
        }

        internal static void ZakonczProgram()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*                       Koniec Programu                           *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*******************************************************************");
        }

        internal static void PODAJNUMERKARTYKREDYTOWEJ()
        {
            
            Console.WriteLine("PODAJ NUMER KARTY KREDYTOWEJ (CZTERY CYFRY):");
            
        }
        
        

        internal static void PrzekroczonoLIMITKARTY()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIEWYSTARCZAJĄCY LIMIT NA RACHUNKU KARTY");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("PODAJ NUMER KARTY KREDYTOWEJ (CZTERY CYFRY):");

        }

        internal static void WyswietlListeProduktow(List<Produkt> przedmioty)
        {
            Console.WriteLine("Lista Przedmiotów Na Aukcji");
            Console.WriteLine("----------------------------------");
            foreach (var produkt in przedmioty.OrderBy(x => !x.CzyWyrozniony))
            {
                if (produkt.CzyWyrozniony)
                    Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{produkt.Id} {produkt.Nazwa} {produkt.Kategoria} {produkt.Cena} PLN");
                Console.ForegroundColor = ConsoleColor.White;

            }
            Console.WriteLine("Podaj numer produktu który chcesz zakupić:");
            
        }

        internal static void PODAJNAZWĘPRZEDMIOTU()
        {
            while (true)
            {
                Console.WriteLine("PODAJ NAZWE PRZEDMIOTU");
                Console.ReadLine();
                //var wybor = podajkategorie();
                //if (wybor == object.wybor) ;



                //var podananzwa = podajkategorie();

                //Console.ReadLine();
                //var podanacena = Ekran.podajcene();


            }
            //Console.WriteLine("PODAJ KATEGORIE PRZEDMIOTU")) ;
        }

        //private static object podajkategorie()
        //{ while (true) 
        //    {
        //        Console.WriteLine("PODAJ KATEGORIE PRZEDMIOTU");
        //        Console.ReadLine();
        //        var podanacena = Ekran.podajcene();
        //    }



        //}

        //private static object podajcene()
        //{
        //    Console.WriteLine("PODAJ CENE PRZEDMIOTU");
        //    Console.ReadLine();
        //    if Baza.wszystopodane(podananzwa.Nazwa)
        //}

        public static void PokazInfoOBledzieKarty()
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*                 NIEPRAWIDŁOWY NUMER KARTY                       *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*******************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("PODAJ PRAWIDŁOWY NUMER KARTY KREDYTOWEJ (CZTERY CYFRY):");
            
        }

        internal static void PokazInfoOBledzie()
        {
            
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*                 NIEPRAWIDŁOWY NUMER PRODUKTU                    *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*                                                                 *");
            Console.WriteLine("*******************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("PODAJ NUMER PRODUKTU KTÓRY CHCESZ ZAKUPIĆ:");
            
           
        }

        
    }

}

