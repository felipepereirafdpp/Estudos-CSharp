using System.Globalization;

int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

int[,] matriz = new int[M, N];

for (int i = 0; i < M; i++)
{
    string[] vetor = Console.ReadLine().Split(" ");
    for (int j = 0; j < M; j++)
    {
        matriz[i, j] = int.Parse(vetor[j]);
    }
}
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(matriz[i, j]+ " ");
    }
    Console.WriteLine();
}