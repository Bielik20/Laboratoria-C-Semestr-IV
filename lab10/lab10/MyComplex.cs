using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class MyComplex : IPorownanie<MyComplex>
    {
        public double Re { get; private set; }
        public double Im { get; private set; }

        public MyComplex(double Re = 0 , double Im = 0)
        {
            this.Re = Re;
            this.Im = Im;
        }

        public void Wyswietl()
        {
            Console.WriteLine("{ " + Re.ToString() + " , " + Im.ToString() + " }");
        }

        public static MyComplex operator+ (MyComplex A , MyComplex B)
        {
            return new MyComplex(A.Re + B.Re, A.Im + B.Im);
        }

        public static MyComplex operator- (MyComplex A , MyComplex B)
        {
            return new MyComplex(A.Re - B.Re, A.Im - B.Im);
        }

        public static MyComplex operator* (MyComplex A , MyComplex B)
        {
            return new MyComplex();
        }

        public static MyComplex operator/ (MyComplex A, MyComplex B)
        {
            return new MyComplex();
        }

        public double Modol()
        {
            return Math.Sqrt(Math.Pow(Re, 2) + Math.Pow(Re, 2));
        }

        public bool Equals(MyComplex A)
        {
            if (this.Re == A.Re && this.Im == A.Im)
                return true;
            else
                return false;
        }
    }

    interface IPorownanie<T>
    {
        bool Equals(T obj);
    }
}
