using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_08
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int numerosPar, numerosImpar, x , N;
            numerosPar = 0;
            numerosImpar = 0;
            int[] numerosCompletos;

            x = int.Parse(Console.ReadLine());

            numerosCompletos = new int[x];

            for (int i = 0; i < numerosCompletos.Length; i++)
            {
                numerosCompletos[i] = int.Parse(Console.ReadLine());
                N = numerosCompletos[i];
                if (N % 2 == 0)
                {
                    numerosPar++;
                }
                else
                {
                    numerosImpar++;
                }
            }
            Console.WriteLine("Quantidade de pares:" + numerosPar);
            Console.WriteLine("Quantidade de impars: " + numerosImpar);
        }
    }
}
