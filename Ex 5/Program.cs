﻿/*

Exercício 5:
• Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
valores do cálculo de A! e o seu resultado.
Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
• Pesquise sobre “fatorial”

*/



using System;

namespace Ex5.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite o valor inicial: ");
            string strValor = Console.ReadLine();
            int valor = Convert.ToInt32(strValor);

            int fatorial = 1;

            if (valor < 0)
            {
                Console.Write("Digite um número positivo");

                return;

            }

            Console.Write(valor + "! = ");

           




            for (int i = valor; i > 0; i--)
            {
                if (i != 1)
                    Console.Write(i + " x ");

                

                else
                    Console.Write(i);

                fatorial = fatorial * i;
            }

            

            Console.Write(" = " + fatorial);

            Console.ReadKey();
        }
    }
}