using System;
using System.Globalization;

double idade, soma;
int quantidade;

idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
soma = 0.0;
quantidade = 0;
if (idade < 0)
{
    Console.WriteLine("Impossivevel Calcular");
}
else
{
    while (idade >= 0)
    {
        soma += idade;
        quantidade++;
        idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    }

    double media = soma / quantidade;
    Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
}