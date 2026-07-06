using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_05
{
    internal class Exercicio02
    {
        public void Executar()
        {
            int numeroInfromado, soma;
            Console.WriteLine("Informe ate onde quer contar: ");
            numeroInfromado = int.Parse(Console.ReadLine());
            soma = 0;
            while(soma != numeroInfromado)
            {
                soma++;
                Console.WriteLine(soma);
            }
        }
    }
}
