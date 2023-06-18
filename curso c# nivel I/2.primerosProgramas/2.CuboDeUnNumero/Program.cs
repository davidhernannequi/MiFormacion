using System;

namespace CuboDeUnNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR VALORES
            int num1, CuboDeUnNumero;

            //PEDIR UN VALOR
            Console.WriteLine("Ingrese un numero: ");

            num1 = int.Parse(Console.ReadLine());
            
            //PROCESAR EL CUBO DEL VALOR INGRESADO
            CuboDeUnNumero = num1*num1*num1;
            
            //MOSTRAR RESULTADO POR PANTALLA
            Console.WriteLine("El cubo del numero es: " + CuboDeUnNumero);
        }
    }
}