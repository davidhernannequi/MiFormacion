using System;

namespace numeroPrimo.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cont=0;
            
            Console.WriteLine("Ingrese un numero: ");
            num =int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
             if (num%i==0)
                cont++;   
            }
            
            if (cont==2)
                Console.WriteLine("El numero es primo.");
            else
                Console.WriteLine("El numero no es primo");
        }
    }
}
