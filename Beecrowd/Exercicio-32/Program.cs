int M, N;

string[] vetor = Console.ReadLine().Split(" ");
M = int.Parse(vetor[0]);
N = int.Parse(vetor[1]);
int[,] matrizA = new int[M,N];
int[,] matrizB = new int[M, N];
int[,] matrizC = new int[M, N];

for (int i = 0; i < M; i++) 
{
    string[] vetA = Console.ReadLine().Split(" "); 
    for (int j = 0; j < N; j++)
    {
        matrizA[i, j] = int.Parse(vetA[j]);
    }
}
for (int i = 0; i < M; i++) 
{
    string[] vetB = Console.ReadLine().Split(" ");
    for (int j = 0; j < N; j++)
    {
        matrizB[i, j] = int.Parse(vetB[j]);
    }
}
for (int i = 0; i < M; i++) 
{
    for (int j = 0; j < N; j++)
    {
        matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
    }
}

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(matrizC[i, j]+ " ");
    }
    Console.WriteLine();
}
