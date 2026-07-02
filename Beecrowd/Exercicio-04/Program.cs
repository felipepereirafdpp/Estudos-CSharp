
using System.Globalization;

Console.WriteLine("Informe os valores do produto A e B:");
string produtosAeB = Console.ReadLine();
string[] vetor1 = produtosAeB.Split(" ");

double produtoA = double.Parse(vetor1[0],CultureInfo.InvariantCulture);
double produtoB = double.Parse(vetor1[1],CultureInfo.InvariantCulture);

Console.WriteLine("Informe os valores do produto C e D:");
string produtosCeD = Console.ReadLine();
string[] vetor2 = produtosCeD.Split(" ");

double produtoC = double.Parse(vetor2[0], CultureInfo.InvariantCulture);
double produtoD = double.Parse(vetor2[1], CultureInfo.InvariantCulture);

double resposta = ((produtoA * produtoB) - (produtoC * produtoD));

Console.WriteLine("Diferença: " + resposta);