using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyComplex A, B;
            Console.WriteLine("Podaj kolejno wartość rzeczywistą i urojoną liczby A");
            var tempRe = double.Parse(Console.ReadLine());
            var tempIm = double.Parse(Console.ReadLine());
            A = new MyComplex(tempRe, tempIm);
            A.Wyswietl();
            Console.WriteLine("Podaj kolejno wartość rzeczywistą i urojoną liczby B");
            tempRe = double.Parse(Console.ReadLine());
            tempIm = double.Parse(Console.ReadLine());
            B = new MyComplex(tempRe, tempIm);
            B.Wyswietl();

            Console.WriteLine("Wynik dodawania:");
            (A + B).Wyswietl();

            Console.WriteLine("Wynik porównania:");
            //A.Equals(B) ? Console.WriteLine("true") : Console.WriteLine("false");
            if (A == B) Console.WriteLine("true");
            else Console.WriteLine("false");

            Console.ReadKey();
        }
    }
}
