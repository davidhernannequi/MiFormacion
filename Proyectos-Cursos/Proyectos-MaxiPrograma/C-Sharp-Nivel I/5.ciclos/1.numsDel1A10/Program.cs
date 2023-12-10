using System;

namespace _1.numsDel1A10.cs
{
    class Program
    {
        static void Main(string[] args)
        { 
            int x = 0;
            
            Console.WriteLine("1 al 10 con for");
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(i);    
            }
            
            Console.WriteLine("1 al 10 con while");
            while (x<10)
            {
                x++;
                Console.WriteLine(x);
            }
        }
    }
}
