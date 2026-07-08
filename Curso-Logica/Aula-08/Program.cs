//// Aula sobre vetores/Array

using System.Globalization;
using Aula_08;

int x;
double[] vet;

x = int.Parse(Console.ReadLine());
vet = new double[x];

for (int i = 0; i < x; i++)
{

    vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


}
Console.WriteLine("|-----|RESULTADO|-----|");
for (int b = 0; b < vet.Length; b++)
{
    Console.WriteLine(vet[b].ToString("F1"));
}

Console.WriteLine("|-----|RESULTADO 02|-----|");
foreach (double numeros in vet)
{

    Console.WriteLine(numeros);
}


Exercicio01 exercicio01 = new Exercicio01();
exercicio01.Executar();

Exercicio02 exercicio02 = new Exercicio02();
exercicio02.Executar();