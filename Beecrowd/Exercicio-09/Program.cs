Console.WriteLine("Informe um numero");
int numeroInformado = int.Parse(Console.ReadLine());
string intervalo;

switch (numeroInformado)
{

    case <= 0:
        intervalo = "Fora do Intervalo";
        break;

    case <= 25:
        intervalo = "[0,25]";
        break;
    case <= 50:
        intervalo = "(25,50]";
        break;
    case <= 75:
        intervalo = "(50,75]";
        break;
    case <= 100:
        intervalo = "(75,100]";
        break;
    default:
        intervalo = "Fora do Intervalo";
        break;

        


}
Console.WriteLine("INTERVALO: " + intervalo);
Console.ReadLine();
