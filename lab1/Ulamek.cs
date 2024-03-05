using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Ulamek
    {
        public int licznik;
        public int mianownik;

        public Ulamek(int in_licznik, int in_mianownik)
        {
            if(in_mianownik==0){
                throw new ArgumentException("nie da sie przez 0");
            }
            licznik = in_licznik;
            mianownik = in_mianownik;
        }
        public static Ulamek operator*(Ulamek valueA, Ulamek valueB)
        {
            Ulamek wynik = new Ulamek(valueA.licznik * valueB.licznik, valueA.mianownik * valueB.mianownik);
            return wynik;
        }

        public static Ulamek operator -(Ulamek valueA, Ulamek valueB)
        {
            Ulamek wynik = new Ulamek(valueA.licznik - valueB.licznik, valueA.mianownik = valueB.mianownik);
            return wynik;
        }

        public override string ToString()
        {
            return licznik.ToString()+"/"+mianownik.ToString();
        }
    }
}
