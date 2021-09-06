using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            int fibo1 = 0;
            int fibo2 = 1;
            int contador = 0;

            do
            {
                Console.WriteLine("Ingrese el número de numeros de Fibonacci que desea mostrar");
                numero = int.Parse(Console.ReadLine());
            }
            while (numero <= 1);

            Console.WriteLine(fibo1 + "");

            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(fibo2 + " ");
                fibo2 = fibo1 + fibo2;
                fibo1 = fibo2 - fibo1;


                for (int j = 2; j <= numero; j++)
                {
                    if (numero % i == 0)
                    {
                        contador++;

                    }



                }
            }
        }
    }
}













