using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Czytelnik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int ID { get; set; }

        public Czytelnik(string imie, string nazwisko, int id)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            ID= id;
        }
    }
}
