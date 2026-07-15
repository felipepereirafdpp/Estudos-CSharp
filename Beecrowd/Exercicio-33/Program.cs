using System.Globalization;

int N;
double somaPositivo = 0.00;
N = int.Parse(Console.ReadLine());
double[,] matriz = new double[N, N];


for ( int i = 0; i < N; i++)
{
    string[] vetor = Console.ReadLine().Split(" ");
    for (int j = 0; j < N; j++)
    {
        matriz[i, j] = double.Parse(vetor[j],CultureInfo.InvariantCulture);

        if (matriz[i,j] > 0)
        {
            somaPositivo += matriz[i, j];
        }
    }
}
int indiceLinha = int.Parse(Console.ReadLine());
int indiceColuna = int.Parse(Console.ReadLine());


Console.WriteLine("SOMA DOS POSITIVOS: " + somaPositivo.ToString("F1", CultureInfo.InvariantCulture));

Console.Write("LINHA ESCOLHIDA: ");
for (int j = 0; j< N; j++)
{
    Console.Write(matriz[indiceLinha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
}

Console.WriteLine();
Console.Write("COLUNA ESCOLHIDA: ");
for (int i = 0; i < N; i++)
{
    Console.Write(matriz[i, indiceColuna].ToString("F1", CultureInfo.InvariantCulture) + " ");
}

Console.WriteLine();
Console.Write("DIAGONAL PRINCIPAL: ");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {

        if (i == j)
        {
            Console.Write(matriz[i, j].ToString("F1",CultureInfo.InvariantCulture) + " ");
        }


    }
}
Console.WriteLine();
Console.WriteLine("MATRIZ ALTERADA: ");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {

        if (matriz[i, j] < 0)
        {
            matriz[i, j] = matriz[i,j] * matriz[i,j];
        }

        
    }
    
}
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(matriz[i, j].ToString("F1",CultureInfo.InvariantCulture) + " ");
    }
    Console.WriteLine();
}
