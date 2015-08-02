using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(Go).Start();
            Go();
            Console.Read();
        }
        static void Go()
        {
            for (int i = 0; i < 5; i++) Console.Write("+");
        }
    }
}
