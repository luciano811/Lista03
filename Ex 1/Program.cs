/*

Exercício 2:
• Escrever um algoritmo que gera e escreve os números ímpares entre 100
e 200.

*/
using System;

namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double[] impares = new double[100];

            Console.WriteLine("Aqui estão os números ímpares de 1 a 100");


            for (int i = 100; i <= 200; i++)
            {
                
                

                if (i % 2 != 0)

                {

                    Console.WriteLine(i);

                }

                else
                {
                    Console.WriteLine();






                }
               

            }
        }
    }
}

