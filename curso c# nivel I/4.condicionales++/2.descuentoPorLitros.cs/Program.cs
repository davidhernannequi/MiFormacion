using System;

namespace descuentoPorLitros.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            float importeDeVenta, litros;

            Console.WriteLine("Ingrese el Importe de la Venta realizada: ");
            importeDeVenta = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de Litros vendidos: ");
            litros = float.Parse(Console.ReadLine());
        
            if(litros>500)
                importeDeVenta *= 0.75F;
            else if(litros>300)
                importeDeVenta *= 0.85F;
            else if(litros>100)
                importeDeVenta *= 0.90F;
            
            Console.WriteLine("El importe final es: " + importeDeVenta);

        }
    }
}
