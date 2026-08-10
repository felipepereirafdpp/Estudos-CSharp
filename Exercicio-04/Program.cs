

using Exercicio_04;
using System.Globalization;

Console.Write("Qual a cotação do dollar ? ");
double cotacaoDollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Quantos Dollars voce vai comprar ? ");
double quantidadeDollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Valor a ser pago: " + InformacoesDollar.CalcularValorDollar(quantidadeDollar,cotacaoDollar).ToString("F2",CultureInfo.InvariantCulture));