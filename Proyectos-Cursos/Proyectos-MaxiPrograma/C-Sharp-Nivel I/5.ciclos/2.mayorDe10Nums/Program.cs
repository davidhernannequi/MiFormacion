using System;

namespace mayorDe10Nums.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite el ingreso de 10 números
            //y que muestre el mayor de ellos por pantalla. 
            //Solo se debe emitir UN valor por pantalla.
            int num, max = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                if (i == 0)
                    max = num;
                else{    
                    if (num > max)
                        max = num;
                    }
            }
            Console.WriteLine("El mayor numero es: " + max);
        }
    }
}
