





using System;

namespace se3_c
{
    internal class ejer1
    {
        static void main(string[] args)
        {
            string n, c;

            Console.WriteLine("ingrese nombre: ");
            n = Console.ReadLine();
            Console.WriteLine("ingrese carrera: ");
            n = Console.ReadLine();

            Console.WriteLine("\n-----imprecion con + ------");
            Console.WriteLine(n + ", bienvenido al curso FA de la carrera"+c);

            Console.WriteLine("\n-----imprecion con + ------");
            Console.WriteLine($"{n}, Bienvenido al curso FA de la carrera {c}");
            Console.ReadKey();
        }
    }
}
