using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula_02
{
    internal class Exercicio02
    {
        public void Executar()
        {
            Console.WriteLine("Informe o valor dos coeficentes em ordem a , b , c:");
            string frase = Console.ReadLine();
            string[] vetor = frase.Split(" ");
            double a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vetor[2], CultureInfo.InvariantCulture);


            double delta = ((Math.Pow(b, 2)) - 4 * a * c);
            double x1 = ((-b + Math.Sqrt(delta)) / 2 * a);

            double x2 = ((-b - Math.Sqrt(delta)) / 2 * a);

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}
