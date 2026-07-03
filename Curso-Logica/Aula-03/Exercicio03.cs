using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_03
{
    //EXERCICIO DE OPERADORES DE ATRIBUÇÃO CUMULATIVA
    internal class Exercicio03
    {
        public void Executar()
        {
            Console.WriteLine("Informe os minutos consumidos no mes: ");
            int minutos = int.Parse(Console.ReadLine());

            double conta = 50;


            if (minutos > 100)
            {

                conta += ((minutos - 100) * 2);

            }
            Console.WriteLine("O Valor a pagar é de R$" + conta);



        }
    }
}
