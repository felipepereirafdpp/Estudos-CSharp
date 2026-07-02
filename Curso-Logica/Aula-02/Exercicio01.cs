using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula_02
{
    
    internal class Exercicio01
    {
        public void Executar()
        {
            Console.WriteLine("Informe o valor primeiro de Largura e Comprimento do Terreno em Metros: ");
            string frase = Console.ReadLine();

            string[] vetor = frase.Split(" ");

            double largura = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double comprimento = double.Parse(vetor[1], CultureInfo.InvariantCulture);

            double preco = 200;
            double area = largura * comprimento;
            double valorTerreno = area * preco;
            Console.WriteLine("Area Total do Terreno: " + area.ToString("F2",CultureInfo.InvariantCulture) + " metros quadrados");
            Console.WriteLine("Valor Total: " + valorTerreno.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        
        }
    }
}
