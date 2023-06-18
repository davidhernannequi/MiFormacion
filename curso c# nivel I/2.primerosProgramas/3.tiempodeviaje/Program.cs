using System;

namespace calculadoradeedades
{
    class Program
    {
        static void Main(string[] args)
        {
           //3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
           
           //DECLARAR EL TIPO DE DATO DE LAS VARIABLES
           float km, vel, tiempo;

           //PEDIR DATOS
           Console.WriteLine("Ingrese la distancia en KILOMETROS: ");
           km = float.Parse(Console.ReadLine());
           Console.WriteLine("Ingrese la velocidad del vehiculo en KM/H: ");
           vel = float.Parse(Console.ReadLine());

           //PROCESAR DATOS
           tiempo = km/vel;

           //DEVOLVER INFORMACION
           Console.WriteLine("El tiempo estimado de llegada es: " + tiempo.ToString("0.00") + " h");
        }
    }
}
