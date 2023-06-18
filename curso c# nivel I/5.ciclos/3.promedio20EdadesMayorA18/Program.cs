using System;

namespace promedio20EdadesMayorA18
{
    class Program
    {
        static void Main(string[] args)
        {
        int edad, promedio, cont = 0, acu= 0;

        for (int i = 0; i < 20; i++){
        Console.WriteLine("Ingrese una edad: ");
        edad = int.Parse(Console.ReadLine());

        if (edad>18) {
            cont ++;
            acu+=edad;
        }
        }

        promedio = acu/cont;
        

        Console.WriteLine("El promedio de todas las edades mayores a 18 es: " + promedio);
        }
    }
}
