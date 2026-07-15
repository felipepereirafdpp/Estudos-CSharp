int M, N;
int[,] matriz;

string[] vet = Console.ReadLine().Split(" ");
M = int.Parse(vet[0]);
N = int.Parse(vet[1]);

matriz = new int[M, N];

for (int i = 0; i < M; i++)
{
    string[] vetor = Console.ReadLine().Split(" ");

    for(int x = 0; x < N; x++)
    {
        matriz[i, x] = int.Parse(vetor[x]);
    }
}
Console.WriteLine("VALORES NEGATIVOS:");
for (int i = 0; i < M; i++)
{
    for (int x = 0; x < N; x++)
    {
        if (matriz[i, x] < 0)
        {
            Console.WriteLine(matriz[i, x]);
        }
    }
}