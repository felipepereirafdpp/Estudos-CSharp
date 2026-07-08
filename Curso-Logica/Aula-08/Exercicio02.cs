using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_08
{
    internal class Exercicio02
    {
        public void Executar()
        {
            int x;
            int[] numeros;

            x = int.Parse(Console.ReadLine());

            numeros = new int[x];

            for (int i = 0; i < x; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int maiorNumero = numeros[0];
            int menorNumero = numeros[0];

            for (int i = 1; i < x; i++)
            {
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                }

                if (numeros[i] < menorNumero)
                {
                    menorNumero = numeros[i];
                }
            }

            Console.WriteLine("Maior numero: " + maiorNumero);
            Console.WriteLine("Menor numero: " + menorNumero);
        }
    }
}
