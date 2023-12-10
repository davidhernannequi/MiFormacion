using System;

namespace _5.numerosOrdenadosDecrecientes.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;

            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo numero: ");
            n4 = int.Parse(Console.ReadLine());

            if (n1>n2 && n2>n3 && n3>n4)
                Console.WriteLine("Los numeros estan ordenados de forma decreciente.");
        }
    }
}
