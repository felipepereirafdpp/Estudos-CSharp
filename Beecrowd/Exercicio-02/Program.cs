using System.Globalization;

Console.WriteLine("Informe o valor do Raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double pi = Math.PI;

double resposta = pi * raio;

Console.WriteLine("Área do Circulo: " + resposta.ToString("F4",CultureInfo.InvariantCulture));
