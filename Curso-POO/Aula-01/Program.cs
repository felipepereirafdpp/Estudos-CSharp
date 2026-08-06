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


double areaTrianguloX = X.CalularAreaTriangulo();
double areaTrianguloY = Y.CalularAreaTriangulo();


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

string resposta = pessoaA.CalcularIdade(pessoaA, pessoaB);
Console.WriteLine(resposta);



// Exercicios 

// Exercicio 02

Funcionario funcionarioA, funcionarioB;

funcionarioA = new Funcionario();
funcionarioB = new Funcionario();



Console.WriteLine("Dados do primeiro funcionario: ");

Console.Write("Nome:");
funcionarioA.Nome = Console.ReadLine();

Console.Write("Salario:");
funcionarioA.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("Dados do segundo funcionario: ");
Console.Write("Nome:");

funcionarioB.Nome = Console.ReadLine();
Console.Write("Salario:");



funcionarioB.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double mediaSalarial = funcionarioA.CalcularMediaSalarial(funcionarioA, funcionarioB);

Console.WriteLine("Media Salarial: " + mediaSalarial.ToString("F2", CultureInfo.InvariantCulture));