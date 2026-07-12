using System.Globalization;

int N;

N = int.Parse(Console.ReadLine());

string[] nomesAlunos = new string[N];
double[] notaPrimeiroSemestre = new double[N];
double[] notaSegundoSemestre = new double[N];

for (int i = 0; i < N; i++)
{
    string[] dados = Console.ReadLine().Split(" ");
    nomesAlunos[i] = dados[0];
    notaPrimeiroSemestre[i] = double.Parse(dados[1], CultureInfo.InvariantCulture);
    notaSegundoSemestre[i] = double.Parse(dados[2], CultureInfo.InvariantCulture);

}
Console.WriteLine("Alunos Aprovados: ");
for (int i = 0; i < N; i++)
{
    double soma = (notaPrimeiroSemestre[i] + notaSegundoSemestre[i]) / 2;
    if (soma >= 6)
    {
        Console.WriteLine(nomesAlunos[i]);
    }
}