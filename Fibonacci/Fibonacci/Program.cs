using System;

namespace Fibonacci 
{
    internal class Program
    {
        static bool CuadradoPerfecto(int ex)
        {
            int s = (int)Math.Sqrt(ex);

            return (s * s == ex);
        }
        static bool esNacci(int n)
        {
            return CuadradoPerfecto(5 * n * n + 4) || CuadradoPerfecto(5 * n * n - 4);
        }
        static void Main(string[] args)
        {
            int n = 3;

            Console.WriteLine(esNacci(n) ? n + " \nEs parte de la serie" : n + " \nNo es parte de la serie");
        }
    }
}
