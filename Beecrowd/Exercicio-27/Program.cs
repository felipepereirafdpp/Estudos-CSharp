using System.Globalization;

int N;
int lucroBaixo = 0, lucroMedio = 0, lucroAlto = 0;
double somaTotalVenda = 0.00;
double somaTotalCompra = 0.00;

N = int.Parse(Console.ReadLine());

double[] precoCompra = new double[N];
double[] precoVenda = new double[N];


for (int i = 0; i < N; i++)
{
    string[] dados = Console.ReadLine().Split(" ");
    precoCompra[i] = double.Parse(dados[1], CultureInfo.InvariantCulture);
    precoVenda[i] = double.Parse(dados[2], CultureInfo.InvariantCulture);

}

for (int i = 0; i < N; i++)
{
    double margemLucro = (precoVenda[i] - precoCompra[i]) / precoCompra[i];


    if (margemLucro < 0.10)
    {
        lucroBaixo++;
    }
    else if (margemLucro <= 0.20)
    {
        lucroMedio++;
    }
    else
    {
        lucroAlto++;
    }
}
for (int i = 0; i < N; i++)
{
    somaTotalVenda += precoVenda[i];
    somaTotalCompra += precoCompra[i];

}

double lucroTotal = somaTotalVenda - somaTotalCompra;

Console.WriteLine("Lucro abaixo de 10%: "+lucroBaixo);
Console.WriteLine("Lucro entre 10% e 20%: "+lucroMedio);
Console.WriteLine("Lucro acima de 20%: "+ lucroAlto );
Console.WriteLine("Valor total de compra: "+somaTotalCompra.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("Valor total de venda: "+somaTotalVenda.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Lucro total: "+lucroTotal.ToString("F2", CultureInfo.InvariantCulture));