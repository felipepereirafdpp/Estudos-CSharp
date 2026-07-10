int N;
int[] numeros;

int somador = 0;

N = int.Parse(Console.ReadLine());

numeros = new int[N];



string variosNumeros = Console.ReadLine();
string[] vet = variosNumeros.Split(" ");

for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = int.Parse(vet[i]);
}

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.Write(numeros[i]+" ");
        somador++;
    }
}
  

Console.WriteLine("");
Console.WriteLine(somador);