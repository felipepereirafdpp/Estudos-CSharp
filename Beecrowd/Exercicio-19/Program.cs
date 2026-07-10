using System.Globalization;

int N;
double[] numeros;

N = int.Parse(Console.ReadLine());

string variosNumeros = Console.ReadLine();
string[] vet = variosNumeros.Split(" ");


numeros = new double[N]; 

for (int i =  0; i < numeros.Length; i++)
{
    numeros[i] = double.Parse(vet[i],CultureInfo.InvariantCulture);
}

double maiorNumero = numeros[0];
int numeroIndice = 0;

for (int i = 1; i < N; i++)
{
    if (numeros[i] > maiorNumero)
    {
        maiorNumero = numeros[i];
        numeroIndice = i;
    }
}
Console.WriteLine("Maior numero: " + maiorNumero.ToString("F1",CultureInfo.InvariantCulture));
Console.WriteLine("Indice numero: " + numeroIndice);