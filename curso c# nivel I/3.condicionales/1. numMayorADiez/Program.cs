using System;

namespace numMayorADiez.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar un número
            //y luego se emita por pantalla un cartel aclaratorio
            //si “Es mayor a 10” o “No es mayor a 10”.
            
            //0. declarar tipo de variables
            int num1;

            //1. pedir datos
            Console.WriteLine("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());
            
            //2. condicional IF (SI):
            if (num1>10)
                Console.WriteLine("Es mayor a 10.");
            else
                Console.WriteLine("No es mayor a 10.");
            
        }
    }
}
