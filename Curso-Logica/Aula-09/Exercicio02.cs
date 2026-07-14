using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_09
{
    internal class Exercicio02
    {
        public void Executar()
        {
            int M, N, pares = 0, impares = 0, zeros = 0, positivos = 0, negativos = 0;
            string[] vet = Console.ReadLine().Split(" ");
            M = int.Parse(vet[0]);
            N = int.Parse(vet[1]);

            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] vetor = Console.ReadLine().Split(" ");

                for (int x = 0; x < N; x++)
                {

                    matriz[i, x] = int.Parse(vetor[x]);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int x = 0; x < N; x++)
                {
                    if (matriz[i, x] > 0)
                    { 
                        positivos++; 
                    }
                    if (matriz[i, x] % 2 == 0)
                    {
                        pares++;
                    }
                    if (matriz[i, x] % 2 != 0)
                    {
                        impares++;
                    }
                    if (matriz[i, x] == 0)
                    {
                        zeros++;
                    }
                    if (matriz[i,x] < 0)
                    {
                        negativos++;
                    }



                }
            }
            Console.WriteLine("Pares = " + pares);
            Console.WriteLine("Ímpares = " + impares);
            Console.WriteLine("Negativos = " + negativos);
            Console.WriteLine("Positivos =" + positivos);
            Console.WriteLine("Zeros = " + zeros);
        }
    }
}
