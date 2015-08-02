using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe");
            int a = int.Parse(Console.ReadLine());

            if (a <= 0) Console.WriteLine("Ale dzisiaj zimno");
            if (a > 0 && a <= 10) Console.WriteLine("Jeden z dziesieciu");
            if (a > 10) Console.WriteLine("Inna wartosc");

            Console.ReadLine();
        }
    }
}
