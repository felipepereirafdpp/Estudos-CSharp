using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula_06
{
    internal class Exercicio02
    {
        public void Executar()
        {
            double mediaPonterada = 0;
            double  n1, n2, n3;

           int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                string notas = Console.ReadLine();
                string[] vetor = notas.Split(" ");
                n1 = double.Parse(vetor[0]);
                n2 = double.Parse(vetor[1]);
                n3 = double.Parse(vetor[2]);
                mediaPonterada = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

                Console.WriteLine(mediaPonterada.ToString("F1", CultureInfo.InvariantCulture));

            }
           
        }
    }
}
