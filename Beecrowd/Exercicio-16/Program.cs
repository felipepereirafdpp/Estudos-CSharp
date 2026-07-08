int x;
int[] numeros;

x = int.Parse(Console.ReadLine());

numeros = new int[x];

string[] vetor = Console.ReadLine().Split(" ");

for (int i = 0; i < x; i++)
{
    numeros[i] = int.Parse(vetor[i]);
}

for (int i =0; i < x; i++)
{
    if (numeros[i] < 0)
    {
        Console.WriteLine(numeros[i]);
    }
}