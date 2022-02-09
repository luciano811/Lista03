/*

Exercício 3:
• Desenvolver um algoritmo que efetue a soma de todos os números
ímpares que são múltiplos de três e que se encontram no conjunto dos
números de 1 até 500.


*/



using System;

namespace Ex_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!!");

            double[] impares = new double[500];

            double soma = 0;

            Console.WriteLine("Aqui estão os números ímpares e divisíveis por 3 de 1 a 500");

            

            for (int i = 0; i <= 500; i++)
            {



                if (i % 3 == 0 && i % 2 != 0)

                {

                    Console.WriteLine(i);


                    soma += i;

                    if (i >= 495)
                    {
                        Console.WriteLine("A soma é: " + soma);
                    }
                }


               

                

                















            }
        }
    }
}
