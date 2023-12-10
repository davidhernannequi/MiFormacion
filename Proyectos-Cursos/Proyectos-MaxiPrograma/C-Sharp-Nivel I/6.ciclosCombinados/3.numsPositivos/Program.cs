using System;

namespace numsPositivosSeparadosPor0ContarCadaLista.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, grupo = 0, cont;
            
            while(n >= 0) {
                cont = 0;
                grupo++;
                Console.WriteLine("Ingresa un numero: ");
                n = int.Parse(Console.ReadLine());
                
                while (n > 0)
                {
                    cont++;
                    Console.WriteLine("Ingresa un numero: ");
                    n = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("El grupo " + grupo + " tiene " + cont + " numeros");
            }
        }
            
    }
}
