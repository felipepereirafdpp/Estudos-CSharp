using Exercicio_03;
using System.Globalization;

Aluno aluno1 = new Aluno();

aluno1.Nome = Console.ReadLine();
aluno1.NotaPrimeiroTrimestre = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
aluno1.NotaSegundoTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno1.NotaTerceiroTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno1.CalcularSituaçãoAluno();