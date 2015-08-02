using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad3
{
    class Program
    {
        static int licznik = 0;
        static void Main(string[] args)
        {
            new Thread(Licz).Start();
            for (int i = 0; i < 5; i++ )
            {
                Console.Write("_");
                Licz();
                Console.Write("|");
            }

                Console.ReadLine();
        }

        static void Licz()
        {
            Console.WriteLine(licznik++ + " ");
        }
    }
}
