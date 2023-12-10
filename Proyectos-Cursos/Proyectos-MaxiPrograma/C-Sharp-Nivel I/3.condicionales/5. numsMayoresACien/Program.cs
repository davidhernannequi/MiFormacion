using System;

namespace numsMayoresACien.cs
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int num1, num2, num3, num4;

        Console.WriteLine("Ingrese un numero: ");
        num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese otro numero: ");
        num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese otro numero: ");
        num3 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el ultimo numero: ");
        num4 = int.Parse(Console.ReadLine());

        if(num1>100)
            Console.WriteLine(num1);
        
        if(num2>100)
            Console.WriteLine(num2);

        if(num3>100)
            Console.WriteLine(num3);

        if(num4>100)
            Console.WriteLine(num4);

        }
    }
}
