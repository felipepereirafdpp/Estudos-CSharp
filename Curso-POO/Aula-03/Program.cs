using System.Globalization;
class Program
{
    static double pi = 3.14;
    static void Main(string[] args)
    {

        Console.Write("Entre o valor do raio? ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circuferanca = CalcularCircunferenca(raio);
        double volume = CalcularVolume(raio);
        Console.WriteLine("Circuferencia: " + circuferanca.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("Valor de PI: " + pi.ToString("F2", CultureInfo.InvariantCulture));
    }
    static double CalcularCircunferenca(double r)
    {

        return 2.0 * pi * r;
    }
    static double CalcularVolume(double r)
    {
        return 4.0 / 3.0 * pi * Math.Pow(r, 3.0);
    }


}

