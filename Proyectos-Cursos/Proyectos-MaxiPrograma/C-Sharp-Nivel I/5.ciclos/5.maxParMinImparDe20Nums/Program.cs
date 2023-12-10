using System;

namespace maxParMinImparDe20Nums.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, max = 0, min= 0;
            bool banderaPar = false, banderaImpar = false;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                
                if (num % 2 == 0){
                    if (banderaPar == false) {
                        max = num;
                        banderaPar = true;
                    }else if(num > max){
                        max = num;
                    }
                }else{
                    if (banderaImpar == false ) {
                        min = num;
                        banderaImpar = true;
                    }else if (num < min){
                        min = num;
                    }
                }
            }
            Console.WriteLine("El maximo par es: " + max + " y el minimo impar es: " + min);
        }
    }
}
