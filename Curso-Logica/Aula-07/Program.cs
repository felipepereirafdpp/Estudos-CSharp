// Aula sobre faca enquanto


using System.Globalization;
string decisao = "";

do
{
    Console.Write("Digite a temperatura em Celsius: ");

    double tC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double tF = (((9 * tC) / 5) + 32);

    Console.WriteLine("Equivalente em Fahrenheit: " + tF.ToString("F1",CultureInfo.InvariantCulture));
    
    Console.Write("Deseja repetir (s/n)? ");
    
    decisao = Console.ReadLine().ToUpper();

} while (decisao == " ");