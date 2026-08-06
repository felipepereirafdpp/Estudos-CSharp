// Projeto sem POO

using Aula_01;
using System.Globalization;

Exercicio01SemPOO exercicio = new Exercicio01SemPOO();
exercicio.Executar();

// Projeto com POO

Triangulo X, Y;

X = new Triangulo();
Y = new Triangulo();

Console.WriteLine("Entre com as Medidas do triangulo X: ");
X.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
X.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
X.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as Medidas do triangulo Y: ");
Y.LadoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Y.LadoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Y.LadoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double pX = (X.LadoA + X.LadoB + X.LadoC) / 2.0;
double areaTrianguloX = Math.Sqrt(pX * (pX - X.LadoA) * (pX - X.LadoB) * (pX - X.LadoC));

double pY = (Y.LadoA + Y.LadoB + Y.LadoC) / 2.0;
double areaTrianguloY = Math.Sqrt(pY * (pY - Y.LadoA) * (pY - Y.LadoB) * (pY - Y.LadoC));

Console.WriteLine("Área de X: " + areaTrianguloX.ToString("F4"), CultureInfo.InvariantCulture);
Console.WriteLine("Área de Y: " + areaTrianguloY.ToString("F4"), CultureInfo.InvariantCulture);

string sigla;
if (areaTrianguloX > areaTrianguloY)
{
    sigla = "X";
}
else
{
    sigla = "Y";
}

Console.WriteLine("Maior Área: " + sigla);

// Exercicios 

// Exercicio 01

Pessoa pessoaA, pessoaB;
pessoaA = new Pessoa();
pessoaB = new Pessoa();

Console.WriteLine("Dados da primeira pessoa: ");
Console.Write("Nome:");
pessoaA.Nome = Console.ReadLine();
Console.Write("Idade:");
pessoaA.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa:");
Console.Write("Nome:");
pessoaB.Nome = Console.ReadLine();
Console.Write("Idade:");
pessoaB.Idade = int.Parse(Console.ReadLine());

if (pessoaA.Idade > pessoaB.Idade)
{
    Console.WriteLine("Pessoa mais velha: " + pessoaA.Nome);
}
else
{
    Console.WriteLine("Pessoa mais velha: " + pessoaB.Nome);
}


// Exercicios 

// Exercicio 02

Funcionario funcionarioA, funcionarioB;

funcionarioA = new Funcionario();
funcionarioB = new Funcionario();
Console.WriteLine("Dados do primeiro funcionario: ");
Console.Write("Nome:");
funcionarioA.Nome = Console.ReadLine();
Console.Write("Salario:");
funcionarioA.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionario: ");
Console.Write("Nome:");
funcionarioB.Nome = Console.ReadLine();
Console.Write("Salario:");
funcionarioB.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double mediaSalarial = (funcionarioA.Salario + funcionarioB.Salario) / 2;
Console.WriteLine("Media Salarial: " + mediaSalarial.ToString("F2", CultureInfo.InvariantCulture));