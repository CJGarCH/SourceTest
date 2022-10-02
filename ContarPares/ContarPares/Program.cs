using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int ContarPares(int[] arr, int n)
        {
            int pares = 0;

            
            for (int i = 0; i <n; i++)
            {
                if (arr[i] % 2 == 0) { 
                    pares++;

                    Console.WriteLine("\n\nPares: " + pares);
                }
            }
            return pares;
        }
        static void Ordenar(int[] arr)
        {

            Array.Sort(arr);

            Array.Reverse(arr);

            Console.Write("Arreglo:");
            Console.Write("\n");


            foreach (var valor in arr)
            {
                Console.Write( valor + " ");
            }

        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 9, 3, 14, 5, 9 };
            int n = arr.Length;

            Ordenar(arr);

            ContarPares(arr, n);


           // Console.Write("\nPares: " + ContarPares(arr, n));

        }
    }
}
