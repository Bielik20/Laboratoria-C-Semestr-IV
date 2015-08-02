using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imie: ");
            string imie = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Podaj swoje nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Podaj ile masz lat: ");
            int wiek = int.Parse(Console.ReadLine());
            //int wiek = Console.Read(); ZLE
            Console.Clear();

            Console.WriteLine("Nazywasz sie {0} {1}.", imie, nazwisko);
            Console.WriteLine("Masz {0}, wiec urodziles sie w {1}.", wiek, DateTime.Now.Year - wiek);
            Console.ReadLine();
        }
    }
}
