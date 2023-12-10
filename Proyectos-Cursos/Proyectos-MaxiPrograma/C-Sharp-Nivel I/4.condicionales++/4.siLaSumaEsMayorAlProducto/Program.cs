using System;

namespace _4.siLaSumaEsMayorAlProducto.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio
            //si la suma de los dos primeros es mayor al producto del segundo con el tercero.
            
            int num1, num2, num3;

            Console.WriteLine("Ingresa un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa un numero: ");
            num3 = int.Parse(Console.ReadLine());

            if ((num1 + num2)>(num2 * num3))
                Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero.");
        }
    }
}
