int N;
int soma = 0;

N = int.Parse(Console.ReadLine());

int[,] matriz = new int[N, N];

for (int i = 0; i < N; i++)
{
    string[] vet = Console.ReadLine().Split(" ");
    for(int j = 0; j < N; j++)
    {
        matriz[i, j] = int.Parse(vet[j]);
    }
}
for (int i = 0; i < N; i++)
{
    soma = 0;
    for (int j = 0; j < N; j++)
    {
        soma += matriz[i, j]; 
    }
    Console.WriteLine(soma);
}