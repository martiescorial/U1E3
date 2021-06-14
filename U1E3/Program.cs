using System;

namespace U1E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 8;
            Console.WriteLine("X = {0}", X);
            int Y = 4;
            Console.WriteLine("Y = {0}", Y);
            double N = 5.785;
            Console.WriteLine("N = {0}", N);
            double M = 10.173;
            Console.WriteLine("M = {0}", M);
            char C = 'b';
            Console.WriteLine("C = {0}", C);
            Console.WriteLine("Suma = {0}", X + Y);
            Console.WriteLine("Resta = {0}", X - Y);
            Console.WriteLine("Multiplicacion = {0}", X * Y);
            Console.WriteLine("Cociente = {0}", X / Y);
            Console.WriteLine("Resto = {0}", X % Y);
            Console.WriteLine("Suma = {0}", N + M);
            Console.WriteLine("Resta = {0}", N - M);
            Console.WriteLine("Multiplicacion = {0}", N * M);
            Console.WriteLine("Cociente = {0}", N / M);
            Console.WriteLine("Resto = {0}", N % M);
            Console.WriteLine("Suma = {0}", N + X);
            Console.WriteLine("Cociente = {0}", Y / M);
            Console.WriteLine("Resto = {0}", Y % M);
            Console.WriteLine("Doble de X = {0}", 2 * X);
            Console.WriteLine("Doble de Y = {0}", 2 * Y);
            Console.WriteLine("Doble de N = {0}", 2 * N);
            Console.WriteLine("Doble de M = {0}", 2 * M);
            Console.WriteLine("Suma de todas las variables = {0}", X + Y + N + M);
            Console.WriteLine("Producto de todas las variables = {0}", X * Y * N * M);
        }
    }
}
