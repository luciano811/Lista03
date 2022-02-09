/*

Exercício 1:
• Desenvolver um algoritmo que leia a altura de 15 pessoas. Este
programa deverá calcular e mostrar:
a. A menor altura do grupo;
b. A maior altura do grupo;

*/



//Esse problema eu passei um dia inteiro tentando parir e não consegui. Resultado, copiei do tiago. Mas eu vi qual é a manha, isso que importa hahah


using System;

namespace Exercicio01.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] alturas = new double[15];

            double maiorAltura = alturas[0];
            double menorAltura = 1;

            int i = 0;
            do
            {
                Console.Write("Qual a altura? ");
                string strAltura = Console.ReadLine();
                alturas[i] = Convert.ToDouble(strAltura);

                if (alturas[i] <= menorAltura)
                    menorAltura = alturas[i];

                if (alturas[i] > maiorAltura)
                    maiorAltura = alturas[i];

                i++;
            } while (i < 15);

            Console.WriteLine("A maior altura é: " + maiorAltura);
            Console.WriteLine("A menor altura é: " + menorAltura);
        }
    }
}






/*
 
Prova da minhas tentativa:


{
        static void Main(string[] args)
        {
                       
            int[] alturas = { 188, 189, 175, 168, 166, 159, 186, 176, 199, 157, 168, 163, 175, 163, 175 };
            int menor, maior;
            int varavel;
            
            variavel = alturas[0];
            for (int i = 1; i < alturas.Length; i++)    
            {
                if(alturas[i] < variavel)
                    menor = alturas[i];
            }
            variavel = alturas[0];
            for (int i = 1; i < alturas.Length; i++)    
            {
                if(alturas[i] > variavel)
                    maior = alturas[i];
            }
            Console.WriteLine("Maior altura: "+maior+   "           Menor altura " +menor);
        }

*/