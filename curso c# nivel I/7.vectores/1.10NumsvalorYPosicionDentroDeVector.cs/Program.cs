using System;

namespace _10NumsvalorYPosicionDentroDeVector.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            // Luego recorrer los elementos y determinar e informar 
            //cuál es el valor máximo y su posición dentro del vector.
           
           int[] vNum = new int [10];
           int n, pos = 0, max;
           for (int i = 0; i < 10; i++)
           {
            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            vNum[i] = n;
           }

           max = vNum[0];
           for (int i = 0; i < 10; i++)
           {
            if (vNum[i] > max) {
                max = vNum[i];
                pos = i + 1;
                }
           }
           Console.WriteLine("El maximo nuero es: " + max);
           Console.WriteLine("Su posicion es: " + pos);

        }
    }
}
