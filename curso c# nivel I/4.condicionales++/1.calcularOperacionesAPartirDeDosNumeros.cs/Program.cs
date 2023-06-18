using System;

namespace calcularOperacionesAPartirDeDosNumeros.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res;

            Console.WriteLine("Ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 == num2){
                res = num1 + num2;
                Console.WriteLine("El resultado de la Suma es: " + res);}
            else if(num1 > num2){
                res = num1 - num2;
                Console.WriteLine("El resultado de la Resta es: " + res);}
            else if(num1 < num2){
                res = num1 * num2;
                Console.WriteLine("El resultado de la Multiplicacion es: " + res);}
        }
    }
}
