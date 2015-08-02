
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad4
{
    class Program
    {
        static readonly object blokada = new object();
        static bool done;
        static void Main(string[] args)
        {
            new Thread(Go).Start();
            Go();
            

            Console.ReadLine();
        }

        static void Go()
        {
            lock (blokada)
            {
                Console.WriteLine("Zaczynam");
                if(!done)
                {
                    for (int i = 0; i<1000000 ; i++)
                    {
                        for (int j = 0; j <1000; j++)
                        {
                            int a = (i * j) % 2;
                        }
                    }
                    Console.WriteLine("Koniec");
                    done = true;
                }
            }
        }
    }
}
