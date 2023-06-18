using System;

namespace _3.localPcSeleccionDeArticulos.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesador,ram, disco;
            float importe;

            Console.WriteLine("Ingrese una opcion de Procesador (1-2-3): ");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una opcion de RAM (1-2-3): ");
            ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese una opcion de disco SI(1)-NO(0): ");
            disco = int.Parse(Console.ReadLine());
            importe = 0;
            switch (procesador){
                case 1:
                    switch (ram){
                        case 1:
                            importe = 800;
                        break;
                        case 2:
                            importe = 900;
                        break;
                        case 3:
                            importe = 1000;
                        break;
                        }
                break;

                case 2:
                    switch (ram) {
                        case 1:
                            importe = 900;
                        break;
                        case 2:
                            importe = 1000;
                        break;
                        case 3:
                            importe = 1400;
                        break;
                    }
                break;

                case 3:
                    switch (ram){
                        case 1:    
                            importe = 1200;
                        break;
                        case 2:
                            importe = 1400;
                        break;
                        case 3:
                            importe = 2000;
                        break;
                    }
                break; 
            }
            if (disco==1)
                importe += 300;
            
            Console.WriteLine("El importe final es: " + importe);
        }
    }
}
