using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTelefono
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Telefono samsung = new Telefono();
           samsung.CodigoOperador = int.Parse(Console.ReadLine());

           Console.Write(samsung.CodigoOperador);
           Console.ReadKey();
        }
    }
}