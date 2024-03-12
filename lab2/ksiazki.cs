using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class Ksiazka
    {
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public int RokWydania { get; set; }
        public string Wydawnictwo { get; set; }
        public int ISBN { get; set; }
        public string Jezyk { get; set; }
        public Ksiazka(string tytul, string autor, int rokWydania)
        {
            Tytul = tytul;
            Autor = autor;
            RokWydania = rokWydania;
        }

        public abstract void WyswietlInformacje();
    }

    public class Czasopismo : Ksiazka
    {
        public int NumerWydan { get; set; }

        public Czasopismo(string tytul, string autor, int rokWydania, int numerWydan)
            : base(tytul, autor, rokWydania)
        {
            NumerWydan = numerWydan;
        }

        public override void WyswietlInformacje()
        {
            Console.WriteLine($"Czasopismo: {Tytul}, Autor: {Autor}, Rok Wydania: {RokWydania}, Numer: {NumerWydan}");
        }
    }

    public class Biografia : Ksiazka
    {
        public string OpisanaOsoba { get; set; }

        public Biografia(string tytul, string autor, int rokWydania, string opisanaOsobowosc)
            : base(tytul, autor, rokWydania)
        {
            OpisanaOsoba = opisanaOsobowosc;
        }

        public override void WyswietlInformacje()
        {
            Console.WriteLine($"Biografia: {Tytul}, Autor: {Autor}, Rok Wydania: {RokWydania}, Opisana Osobowosc: {OpisanaOsoba}");
        }
    }

    public class Powiesc : Ksiazka
    {
        public string Gatunek { get; set; }

        public Powiesc(string tytul, string autor, int rokWydania, string gatunek)
            : base(tytul, autor, rokWydania)
        {
            Gatunek = gatunek;
        }

        public override void WyswietlInformacje()
        {
            Console.WriteLine($"Powiesc: {Tytul}, Autor: {Autor}, Rok Wydania: {RokWydania}, Gatunek: {Gatunek}");
        }
    }
}
