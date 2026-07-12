using System.Globalization;

int N;
N = int.Parse(Console.ReadLine());
double[] altura = new double[N];
string[] sexo = new string[N];


for (int i = 0; i < N; i++)
{
    string[] dados = Console.ReadLine().Split(" ");
    altura[i] = double.Parse(dados[0], CultureInfo.InvariantCulture);
    sexo[i] = dados[1].ToUpper();
}
double menorAltura = altura[0];
double maiorAltura = 0;
double soma = 0;
int contadorHomem = 0;
int contadorMulher = 0;
for (int i = 0; i < N; i++)
{
    if (altura[i] > maiorAltura)
    {
        maiorAltura = altura[i];
    }
    if (altura[i] < menorAltura)
    {
        menorAltura = altura[i];
    }
    if (sexo[i] == "F")
    {
        soma += altura[i];
        contadorMulher++;
    }
    if (sexo[i] == "M")
    {
        contadorHomem++;
    }
}


double media = soma / contadorMulher ;
Console.WriteLine("Menor altura = " + menorAltura.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2", CultureInfo.InvariantCulture) );
Console.WriteLine("Numero de homens = " + contadorHomem);