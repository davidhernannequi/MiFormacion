using System;

namespace casaDeVideojuegosImporteDeVenta.cs
{
    class Program
    {
        static void Main(string[] args)
        {
        //3. Una casa de video juegos otorga un descuento
        //dependiendo del importe de la compra realizada según los siguientes valores:

        //Si el importe es menor a ARS 1000, no hay descuento.
        //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
        //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
        //Hacer un programa para ingresar un importe de venta
        //y luego muestre por pantalla el importe final con el descuento que corresponda.
        
        //0.declarar tipo de dato de variable
        float importeInicial, importeFinal;
        const float descuentoMenor = 0.9F, descuentoMayor = 0.82F;

        //1. pedir datos
        Console.WriteLine("Ingrese el importe de la compra: ");
        importeInicial = float.Parse(Console.ReadLine());

        //2. IF
        if (importeInicial>=5000)
            importeFinal = importeInicial*descuentoMayor;
        else if(importeInicial>=1000)
            importeFinal = importeInicial*descuentoMenor;
        else
            importeFinal = importeInicial;

        //3. Mostrar informacion
        Console.WriteLine("El Importe Final es: " + importeFinal.ToString("0.00"));
        
        }
    }
}
