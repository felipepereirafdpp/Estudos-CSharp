using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_09
{
    internal class Exercicio01
    {

        public void Executar()
        {
            int L, C, soma = 0;
            string[] vet = Console.ReadLine().Split(" ");
            L = int.Parse(vet[0]);
            C = int.Parse(vet[1]);
            int[,] matriz = new int[L, C];

            for (int i = 0; i < L; i++)
            {
                string[] vetor = Console.ReadLine().Split(" ");
                for (int x = 0; x < C; x++)
                {
                    matriz[i, x] = int.Parse(vetor[x]);
                    soma += matriz[i, x];
                }
            }

            int menor = matriz[0,0];
            int maior = matriz[0, 0];
            for (int i = 0; i < L; i++)
            {
                for (int x = 0; x < C; x++)
                {
                    if (matriz[i,x] < menor)
                    {
                        menor = matriz[i, x];
                    }
                    if (matriz[i,x] > maior)
                    {
                        maior = matriz[i, x];
                    }
                }
            }
            Console.WriteLine("Soma = " + soma);
            Console.WriteLine("Maior = " + maior);
            Console.WriteLine("Menor = " + menor);
        }
    }
}
