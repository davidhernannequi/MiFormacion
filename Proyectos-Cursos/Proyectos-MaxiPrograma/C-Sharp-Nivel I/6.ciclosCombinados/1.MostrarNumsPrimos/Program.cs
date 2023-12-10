using System;

namespace de10NumsMostrarCuantosSonPrimos.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, cont, contPrimos = 0;

            for (int x = 0; x < 10; x++){
                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
                cont = 0;
                for (int i = 1; i <= n; i++){
                if (n%i==0)
                    cont++;
                }
                if (cont==2)
                    contPrimos++;
            }
            Console.WriteLine("Hay " + contPrimos + " numeros primos.");
        }
    }
}
