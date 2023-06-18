using System;

namespace vectorDe10IntMostrarMayoresAlPromedio.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] vNum = new int [10];
            int n, acu;
            float prom = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                vNum[i] = n;
            }
            
            acu = 0;

            for (int i = 0; i < 10; i++)
            {
                acu+=vNum[i];
            }

            prom = acu / 10;
            for (int i = 0; i < 10; i++)
            {
                if (vNum[i] > prom)
                {
                    Console.WriteLine(vNum[i] + " es mayor al promedio.");
                }
            }

        }
    }
}
