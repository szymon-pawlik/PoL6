using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var czasopismo = new Czasopismo("Nature", "Różni autorzy", 2020, 5);
            var biografia = new Biografia("Steve Jobs", "Walter Isaacson", 2011, "Steve Jobs");
            var powiesc = new Powiesc("Wiedźmin - Ostatnie życzenie", "Andrzej Sapkowski", 1993, "Fantasy");

            czasopismo.WyswietlInformacje();
            biografia.WyswietlInformacje();
            powiesc.WyswietlInformacje();
        }
    }
}
