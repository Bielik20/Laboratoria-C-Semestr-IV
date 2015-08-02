using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj pierwszą liczbe: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj druga liczbe: ");
            int b = int.Parse(Console.ReadLine());

            switch (a == b)
            {
                case true:
                    Console.WriteLine("Liczba {0} jest rowna liczbie {1}", a, b); break;
                case false:
                    switch (a > b)
                    {
                        case true:
                            Console.WriteLine("Liczba {0} jest wieksza od liczby {1}.", a, b); break;
                        case false:
                            Console.WriteLine("Liczba {1} jest wieksza od liczby {0}.", a, b); break;
                    }
                    break;
            }

            Console.ReadLine();
                    
        }
    }
}
