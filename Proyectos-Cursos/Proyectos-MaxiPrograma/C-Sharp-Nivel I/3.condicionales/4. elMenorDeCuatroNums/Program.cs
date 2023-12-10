using System;

namespace elMenorDeCuatroNums.cs
{
    class Program
    {
        static void Main(string[] args)
        {
        int num1, num2, num3, num4, min;

        Console.WriteLine("Ingrese un numero: ");
        num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese otro numero: ");
        num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese otro numero: ");
        num3 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el ultimo numero: ");
        num4 = int.Parse(Console.ReadLine());
        
        if (num1<num2)
            min = num1;
        else
            min = num2;
        
        if (num3<min)
            min = num3;
        
        if (num4<min)
            min = num4;
        Console.WriteLine("El menor es: " + min);


        }
    }
}
