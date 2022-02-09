/*

Exercício 4:
• Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e
calcule a tabuada de N.
• Mostre a tabuada na forma: 0 x N = 0, 1 x N = 1N, 2 x N = 2N, ..., 10 x N =
10N.

*/


using System;

namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos calcular a taboada de 1 a 10");

            int N;

                        
            Console.WriteLine("Digite o número de 1 a 10: ");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            if (N>=0 && N<=10) 
            
            {
                for (int i = 0; i <= 10; i++)
                {

                    Console.Write(N);

                    Console.Write("X" + i);



                    int p = N * +i;

                    Console.Write(" = ");

                    Console.WriteLine(p);
                    

                    


                }

                

            }




            if (N < 0 || N > 10)

                {

                Console.WriteLine("O número não está entre 1 e 10 ");





            }








            

            Console.ReadKey();










        }
    }
}
