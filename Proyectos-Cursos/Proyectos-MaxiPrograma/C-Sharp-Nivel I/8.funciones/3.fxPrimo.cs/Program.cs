using System;

namespace _3.fxPrimo.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3. Hacer una función llamada “primo” 
            que reciba un número entero
            y devuelva 1 si el número es primo o cero si no lo es. 
            Hacer un programa para ingresar números. 
            El lote corta cuando se ingresa un número cero. 
            Informar el promedio teniendo en cuenta sólo los números primos.*/
            
            int nro, cont = 0, acu = 0;
            float promedio;

            Console.WriteLine("Ingrese un nro: ");
            nro = int.Parse(Console.ReadLine());

            while (nro > 0)
            {
                 
            }

        }

        static bool primo(int n){
            int cont = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    cont++;
            }

            if (cont == 2)
                return true;
            else
                return false;            
        }
    }
}
