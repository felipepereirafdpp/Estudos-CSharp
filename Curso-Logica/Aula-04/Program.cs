// Aula sobre Switch Case
using System.Globalization;

Console.WriteLine("informe o Numero do Dia Desejado Ex: 1:Domingo , 2:Segunda ...");
int diaInformando = int.Parse(Console.ReadLine());
string dia;
switch (diaInformando)
{
    case 1:
        dia = "Domingo";
        break;
    case 2:
        dia = "Segunda";
        break;
    case 3:
        dia = "Terça";
        break;
    case 4:
        dia = "Quarta";
        break;
    case 5:
        dia = "Quinta";
        break;
    case 6:
        dia = "Sexta";
        break;
    case 7:
        dia = "Sabado";
        break;
    default:
        dia = "Numero Invalido somente entre 1 á 7";
        break;
}
Console.Write("Dia da Semana: " + dia);
Console.ReadLine();

