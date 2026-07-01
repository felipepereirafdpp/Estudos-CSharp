using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula_01
{
    internal class Exercicio02
    {
        public void Executar()
        {
            Console.WriteLine("Entre com seu Nome Completo: ");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quarto tem na sua casa ? ");
            int quantidadeQuarto = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto ?");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu ultimo nome, idade e altura");
            string frase = Console.ReadLine();

            string[] vetor = frase.Split(" ");

            string ultimoNome = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Nome Completo: " + nomeCompleto);
            Console.WriteLine("Quantidade de Quartos: " + quantidadeQuarto);
            Console.WriteLine("Preço: " + precoProduto);
            Console.WriteLine("Ultimo Nome: " + ultimoNome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
