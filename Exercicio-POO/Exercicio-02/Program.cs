using Exercicio_02;
using System.Globalization;

Funcionario Funcionario1 = new Funcionario();
Funcionario1.Nome = Console.ReadLine();
Funcionario1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Funcionario1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Funcionario: " + Funcionario1.Nome + ", R$"+ Funcionario1.SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture));

Console.Write("Digite a porcentagem para aumentar o salario: ");
double quantidade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Funcionario1.AumentarSalario(quantidade);

Console.WriteLine("Dados Atualizados: " + Funcionario1.Nome + ", R$" + Funcionario1.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));