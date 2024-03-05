using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ulamek a = new Ulamek(5,4);
            Ulamek b = new Ulamek(7,4);

            Ulamek c = a - b;

            Console.WriteLine(c.ToString());
            Console.ReadLine();

        }
    }
}
