using System;

namespace _4.sueldoCasaDeComputacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000
            // más una comisión del 5% sobre el total facturado por cada empleado.
            //Hacer un programa para ingresar el total facturado por un empleado
            //y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            
            //0.Declarar tipo de dato de las variables
            const float SueldoMensual = 15000F;
            const float PorcentajeDeComision = 0.05F;
            float TotalFacturado ,Comision , SueldoFinal;
            
            //1.Pedir ingreso de datos
            Console.WriteLine("Ingrese el Total Facturado: ");
            TotalFacturado = float.Parse(Console.ReadLine());
            
            //2.Realizar procesamiento de datos
            Comision = TotalFacturado*PorcentajeDeComision;
            SueldoFinal = SueldoMensual + Comision;
            
            //3.Mostrar informacion por pantalla
            Console.WriteLine("El Sueldo Final es: " + SueldoFinal);
        }
    }
}
