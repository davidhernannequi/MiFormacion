using System;

namespace numPositivoNegativoCero.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa para ingresar un número
            //luego se emita un cartel por pantalla “Positivo” si es mayor a cero
            //“Negativo” si el número es menor a cero
            //o “Cero” si el número es igual a cero.

            //0. declarar variables
            float num;

            //1. pedir datos
            Console.WriteLine("Ingrese un numero: ");
            num = float.Parse(Console.ReadLine());

            //2. IF/ELSE IF/ ELSE
            if (num==0)
                Console.WriteLine("Cero");
            else if (num>0)
                Console.WriteLine("Positivo");
            else
                Console.WriteLine("Negativo");

        }
    }
}
