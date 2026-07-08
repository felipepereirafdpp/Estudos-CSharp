using System.Globalization;

int x;
double somaAlturas;
double alturaMedia;
double[] altura;
int[] idade;

x = int.Parse(Console.ReadLine());
altura = new double[x];
idade = new int[x];
somaAlturas = 0;
alturaMedia = 0;
int quantidadeMenores =0;


for (int i = 0; i < x; i++)
{
    string[] vet = Console.ReadLine().Split(" ");
    idade[i] = int.Parse(vet[1]);
    altura[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);


}
for (int i = 0; i < altura.Length; i++)
{
    somaAlturas += altura[i];

}
for (int i = 0; i < idade.Length; i++)
{
    if (idade[i] < 16)
    {
        quantidadeMenores++;
    }
}
double porcentagemIdade = (double)quantidadeMenores / x * 100.0;
alturaMedia = (somaAlturas / x);

Console.WriteLine("Altura Média: " + alturaMedia.ToString("F1", CultureInfo.InvariantCulture));
Console.WriteLine("Pessoas com menos de 16 anos: "+ porcentagemIdade.ToString("F0",CultureInfo.InvariantCulture)+"%");