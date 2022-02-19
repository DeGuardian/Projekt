using System;
using System.Collections.Generic;
using System.Linq;

namespace sklep_aukcyjny
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Portal portal = new Portal();
            while (true)
            {
                var WyborKlienta = Ekran.PokazMenu();
                if (WyborKlienta == "1")
                {
                    Ekran.WyswietlListeProduktow(portal.Produkty);
                    {

                        while (true)
                        {
                            var Numerproduktu = int.Parse(Console.ReadLine());
                            var produktDoKupienia = portal.Produkty.FirstOrDefault(x => x.Id == Numerproduktu);
                            if (produktDoKupienia != null)
                            {
                                Ekran.PODAJNUMERKARTYKREDYTOWEJ();
                                while (true)
                                {
                                    string Numerkarty = Console.ReadLine();
                                    var karta = portal.Karty.FirstOrDefault(x => x.NumerKarty == Numerkarty);
                                    if (karta != null)
                                    {
                                        if (karta.Limit >= produktDoKupienia.Cena)
                                        {
                                            Baza.WyswietlListedostepu(karta.Nazwa, produktDoKupienia.Nazwa, produktDoKupienia.Cena, karta.NumerKarty);
                                        }
                                        else Ekran.PrzekroczonoLIMITKARTY();

                                    }
                                    else Ekran.PokazInfoOBledzieKarty();
                                }
                            }
                            else Ekran.PokazInfoOBledzie();



                        }


                    }

                }
                else if (WyborKlienta == "2")
                {
                    Ekran.PODAJNAZWĘPRZEDMIOTU();
                }



                if (WyborKlienta == "3")
                    Console.Clear();
                    Ekran.ZakonczProgram();

            }


        }

    }

    }

