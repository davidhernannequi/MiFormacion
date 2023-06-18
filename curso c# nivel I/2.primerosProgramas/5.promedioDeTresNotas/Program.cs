using System;

namespace _5.promedioDeTresNotas.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno
            //y luego calcule y emita por pantalla el promedio final.
           
            //0.Declaro variables y su tipo.
            float promedioDeTresNotas;
            int Nota1, Nota2, Nota3;

            //1.Inicializo variables
            Console.WriteLine("Ingrese una nota: ");
            Nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otra nota: ");
            Nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la ultima nota: "); 
            Nota3 = int.Parse(Console.ReadLine());

            //2.Proceso datos
            promedioDeTresNotas = (Nota1 + Nota2 + Nota3) / 3;

            //3.Muestro por pantalla la informacion   
            Console.WriteLine("El promedio de notas es: " + promedioDeTresNotas.ToString("0.00"));
            
        }
    }
}
