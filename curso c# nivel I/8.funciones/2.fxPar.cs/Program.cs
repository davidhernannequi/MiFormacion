using System;

namespace fxPar.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer una función llamada “par” que reciba un número entero
            //y devuelva 1 si es par o cero si no lo es. 
            //Hacer un programa para ingresar 20 números
            //y mostrar por pantalla cuántos son pares.
            int cont = 0, nro;

            for (int x=0; x<5; x++){
                Console.Write("Ingrese un numero: ");
                nro = int.Parse(Console.ReadLine());
                if (par(nro)){
                cont++;
                }
            }

            Console.WriteLine("Hay " + cont + " numeros pares");
      

        }

        static bool par(int n){
            if(n % 2 == 0)
                return true;
            else
                return false;
        
        }
    }
}
