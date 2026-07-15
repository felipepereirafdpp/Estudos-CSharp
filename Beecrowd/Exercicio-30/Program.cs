int N;

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

int maiorNumero;

for (int i = 0; i < N; i++)
{
     maiorNumero = matriz[i,0];

    for (int j = 0; j < N; j++)
    {
        if (matriz[i,j] > maiorNumero)
        {
            maiorNumero = matriz[i, j];
        }
    }
    Console.WriteLine(maiorNumero);
}