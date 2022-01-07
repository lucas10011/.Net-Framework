using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        // Trocar Específicos
        private static void TrocarInteiro(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        private static void TrocarBoolean(ref bool a, ref bool b)
        {
            bool aux = a;
            a = b;
            b = aux;
        }

        private static void TrocarDouble(ref double a, ref double b)
        {
            double aux = a;
            a = b;
            b = aux;
        }

        // Trocar Genérico
        private static void Trocar<T>(ref T a, ref T b)
        {
            T aux = a;
            a = b;
            b = aux;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            bool b1 = true;
            bool b2 = false;
            Trocar<int>(ref a, ref b);
            Trocar<bool>(ref b1, ref b2);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.ReadLine();
        }

        private static void TrocarTipos()
        {
            // trocando inteiros
            int a = 10;
            int b = 20;
            TrocarInteiro(ref a, ref b);
            Console.WriteLine("A: " + a);
            Console.WriteLine("B: " + b);
            // trocando bool
            bool b1 = true;
            bool b2 = false;
            TrocarBoolean(ref b1, ref b2);
            Console.WriteLine("B1: " + b1);
            Console.WriteLine("B2: " + b2);
            // trocando double
            double d1 = 10.3;
            double d2 = 20.4;
            TrocarDouble(ref d1, ref d2);
            Console.WriteLine("D1: " + d1);
            Console.WriteLine("D2: " + d2);
        }
    }
}
