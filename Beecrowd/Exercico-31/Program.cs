int N;
int soma = 0;
N = int.Parse(Console.ReadLine());
int[,] matriz = new int[N, N];

for (int i = 0; i < N; i++)
{
    string[] vetor = Console.ReadLine().Split(" ");
    for (int j = 0; j < N; j++)
    {
        matriz[i, j] = int.Parse(vetor[j]);
    }
}
for (int i = 0; i < N; i++)
{ 
    for (int j = 0; j < N; j++)
    {
        if (j > i)
        {
            soma += matriz[i, j];
        }
    }
}
Console.WriteLine(soma);