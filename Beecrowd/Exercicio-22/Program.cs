using System.Globalization;

int N;
double[] numeros;
double soma = 0;

N = int.Parse(Console.ReadLine());

string[] vet = Console.ReadLine().Split(" ");

numeros = new double[N];

for (int i = 0; i < N ; i++)
{
    numeros[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
    soma += numeros[i];
}

double media = (soma / numeros.Length);
Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));
for (int i = 0; i < N; i++)
{
    if (numeros[i] < media)
    {
        Console.WriteLine(numeros[i].ToString("F1",CultureInfo.InvariantCulture));
    }
}