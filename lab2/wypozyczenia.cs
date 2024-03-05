using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Wypozyczenie
    {
        public Ksiazka Ksiazka { get; set; }
        public Czytelnik Czytelnik { get; set; }
        public DateTime DataWypozyczenia { get; set; }
        public DateTime? DataZwrotu { get; set; }

        public Wypozyczenie(Ksiazka ksiazka, Czytelnik czytelnik)
        {
            Ksiazka = ksiazka;
            Czytelnik = czytelnik;
            DataWypozyczenia = DateTime.Now;
        }

        public void Zwrot()
        {
            DataZwrotu = DateTime.Now;
        }
    }
}
