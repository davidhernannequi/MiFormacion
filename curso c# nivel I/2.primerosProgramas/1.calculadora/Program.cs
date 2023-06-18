using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR LAS VARIABLES indicando su TIPO DE DATO
            //int, float, char, bool.
            int num1, num2, resultado;

            //PEDIR 2 NUMEROS
            Console.WriteLine("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            num2 = int.Parse(Console.ReadLine());
            
            //REALIZAR SUMA
            resultado = num1 + num2;
            
            //MOSTRAR RESULTADO
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }
    }
}
