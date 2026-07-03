using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula_03
{
    internal class Exercicio02
    {
        public void Executar() {
            double delta, a, b, c;

            Console.WriteLine("Informe os coefientes");
            string coeficientes = Console.ReadLine();
            string[] vetor = coeficientes.Split(' ');

            
            a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            c = double.Parse(vetor[2], CultureInfo.InvariantCulture);


            delta = ((Math.Pow(b, 2)) - 4 * a * c);

            if (a <= 0 || delta <= 0)
            {
                Console.WriteLine("Impossivel Calcular");
            }
            else
            {
                double x1 = ((-b + Math.Sqrt(delta)) / 2 * a);

                double x2 = ((-b - Math.Sqrt(delta)) / 2 * a);

                Console.WriteLine("x1 = " + x1.ToString("F5",CultureInfo.InvariantCulture));
                Console.WriteLine("x2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));

            }

            Console.ReadLine();
        }
    }
}
