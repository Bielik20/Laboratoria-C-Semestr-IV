using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mojWatek = new Thread(PiszA);
            mojWatek.Start();

            for (int i = 0; i < 1000; i++) Console.Write("B");

            Console.ReadLine();
        }

        static void PiszA()
        {
            for (int i = 0; i < 1000; i++)
                Console.Write("A");
        }
    }
}
