using System;

namespace listaSeparadasPor0PorcentajeDeImparesYContarSiEstanOrdenados.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, contNum = 0, contImp = 0, MaxGrupoImp = 0, contOrd = 0;
            double porcImp, porcMax=-1;
            bool bandOrd = true;

            for (int i = 0; i < 5; i++) {
                Console.WriteLine("Ingrese un numero: ");  
                n = int.Parse(Console.ReadLine());
                
                while (n != 0) {
                contNum++;
                if (n%2!=0)
                    contImp++;
                Console.WriteLine("Ingrese un numero: ");  
                n = int.Parse(Console.ReadLine());
                }// fin del while
                porcImp = (contImp*100)/contNum;

                if (porcImp>porcMax) {
                    porcMax = porcImp;
                    MaxGrupoImp = i+1;
                    }
                    
            }//fin del for
            Console.WriteLine("El maximo grupo impar es: " + MaxGrupoImp);
        }
    }
}
