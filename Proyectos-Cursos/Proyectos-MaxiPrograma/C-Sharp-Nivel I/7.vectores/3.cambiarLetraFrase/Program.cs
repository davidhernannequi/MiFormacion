using System;

namespace cambiarUnaLetraDeFrase.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vFrase = new char [30];
            char letra;
            char letraOriginal;
            char nuevaLetra;
            int i = 0;
            
            Console.Write("Ingrese letras para la frase: ");
            letra = char.Parse(Console.ReadLine());

            while (letra != '0' && i<30)
            {
                vFrase[i] = letra;
                Console.Write("Ingrese letras para la frase: ");
                letra = char.Parse(Console.ReadLine());
                i++;
            }
            
            vFrase[i] = '\0';
            Console.WriteLine("La frase actual es: ");
            i = 0;
            while (vFrase[i] != '\0' && i<30) 
            {
                Console.WriteLine(vFrase[i]);
                i++;    
            }

            Console.WriteLine("Ingrese la letra de la frase que quiere cambiar: ");
            letraOriginal = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la letra nueva para la frase: ");
            nuevaLetra = char.Parse(Console.ReadLine());
            
            i = 0;
            while (vFrase[i] != '\0' && i<30)
            {
                if (vFrase[i] == letraOriginal)
                    vFrase[i] = nuevaLetra;

                i++;
            }

            Console.WriteLine("La frase nueva es: ");
            
            i = 0;
            while (vFrase[i] != '\0' && i<30)
            {
                Console.Write(vFrase[i]);
                i++;
            }
            
        }
    }
}
