using System.Globalization;

int N;
double soma = 0.0;
int numerosPares = 0;


N = int.Parse(Console.ReadLine());

int[] numeros = new int[N];

string[] vetor = Console.ReadLine().Split(" ");

for (int i = 0; i < N; i++)
{
    numeros[i] = int.Parse(vetor[i]);

    if (numeros[i] % 2 == 0)
    {
        soma += numeros[i];
        numerosPares++;
    }
}

double media = (soma / numerosPares);

Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
