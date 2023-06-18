using System;

namespace _4.articulos15NumArtCantVendida.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vAcu = new int [15];

            for (int i = 0; i < 15; i++)
            {
                vAcu[i] = 0;
            }

            int nA, cV, art, max;

            Console.WriteLine("Ingrese el numero de articulo: ");
            nA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cV = int.Parse(Console.ReadLine());

            while (nA !=0)
            {
                vAcu[nA-1] += cV;

            Console.WriteLine("Ingrese el numero de articulo: ");
            nA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cV = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("La cantidad vendida del articulo numero 10 es: " + vAcu[9]);

            for (int i = 0; i < 15; i++)
            {
                if (vAcu[i] == 0)
                    Console.WriteLine("Los numeros de articulos que no registraron ventas son: " + i+1);
            }

            max = vAcu[0];
            art = 1;

            for (int i = 0; i < 15; i++)
            {
                if (vAcu[i]>max)
                {
                    max = vAcu[i];
                    art = i +1;
                }
            }

            Console.WriteLine("El nro de articulo mas vendido es: " + art + "y sutotal de ventas es: " + max);
        }

    }
}
