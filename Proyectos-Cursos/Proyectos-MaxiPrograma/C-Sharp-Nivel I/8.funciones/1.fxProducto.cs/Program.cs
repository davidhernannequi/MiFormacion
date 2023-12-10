using System;

namespace fxproducto.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer una función llamada “producto” 
            //que reciba dos números enteros y que devuelva el producto de ambos.
            //Luego hacer un programa que pida
            //el precio de un artículo y la cantidad vendida
            //y muestre por pantalla el monto total a pagar. Usar la función.
            
            int precio, cant, tt;

            Console.Write("Ingrese el precio del producto: ");
            precio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de productos: ");
            cant = int.Parse(Console.ReadLine());

            tt = producto(precio, cant);

            Console.WriteLine("El total a pagar es " + tt + " pesos.");
        }

        static int producto(int nro1, int nro2){
            return nro1 * nro2;
        }
    }
}
