using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_01
{
    internal class Exercicio01
    {
        public void Executar()
        {
            Console.WriteLine("Qual seu Nome e Sobrenome ?");
            string nomeCompleto = Console.ReadLine();
            string[] vetor = nomeCompleto.Split(" ");
            string primeroNome = vetor[0];
            string segundoNome = vetor[1];

            Console.WriteLine("----------------------");
            Console.WriteLine("Seu Nome: " + primeroNome);
            Console.WriteLine("Seu Sobrenome: " + segundoNome);


        }
    }
}
