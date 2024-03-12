using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Biblioteka
    {
        public List<Ksiazka> Ksiazki { get; set; } = new List<Ksiazka>();
        public List<Czytelnik> Czytelnicy { get; set; } = new List<Czytelnik>();
        public List<Wypozyczenie> Wypozyczenia { get; set; } = new List<Wypozyczenie>();

        public Biblioteka()
        {
            Ksiazki = new List<Ksiazka>();
            Czytelnicy = new List<Czytelnik>();
            Wypozyczenia = new List<Wypozyczenie>();
        }

        public void DodajCzytelnika(Czytelnik czytelnik)
        {
            Czytelnicy.Add(czytelnik);
        }

        public bool CzyKsiazkaDostepna(Ksiazka ksiazka)
        {
            return !Wypozyczenia.Any(w => w.Ksiazka == ksiazka && w.DataZwrotu == null);
        }

        public void ZwrotKsiazki(Ksiazka ksiazka, Czytelnik czytelnik)
        {
            var wypozyczenie = Wypozyczenia.FirstOrDefault(w => w.Ksiazka == ksiazka && w.Czytelnik == czytelnik && w.DataZwrotu == null);
            if (wypozyczenie != null)
            {
                wypozyczenie.Zwrot();
            }
        }


        public void DodajKsiazke(Ksiazka ksiazka)
        {
            Ksiazki.Add(ksiazka);
        }

        public void ZarejestrujWypozyczenie(Ksiazka ksiazka, Czytelnik czytelnik)
        {
            var wypozyczenie = new Wypozyczenie(ksiazka, czytelnik);
            Wypozyczenia.Add(wypozyczenie);
        }
    }
}
