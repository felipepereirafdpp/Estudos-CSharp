using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula_03
{
    internal class Exercicio01
    {
        public void Executar()
        {
            Console.WriteLine("Informe as duas nota dos Ano do Aluno: ");
            string notas = Console.ReadLine();
            string[] vetor = notas.Split(" ");

            double nota1 = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double nota2 = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double notaFinal = (nota1 + nota2);

 
            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1"));

            if (notaFinal < 60.00)
            {
                
                Console.WriteLine("REPROVADO");

            }
            
        }
    }
}
