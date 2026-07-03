

using System.Globalization;

Console.WriteLine("Informe 4 numeros: ");
string numeros = Console.ReadLine();

string[] vet = numeros.Split(" ");

double a, b, c, d;

a = double.Parse(vet[0], CultureInfo.InvariantCulture);
b = double.Parse(vet[1], CultureInfo.InvariantCulture);
c = double.Parse(vet[2], CultureInfo.InvariantCulture);
d = double.Parse(vet[3], CultureInfo.InvariantCulture);

if (b > c &&  d > a && c+d > a+b && c > 0 && d > 0 && a % 2 == 0)
{
   
        Console.WriteLine("Valores Aceitos");
    
}else
{
    Console.WriteLine("Valores nao aceitos");
}