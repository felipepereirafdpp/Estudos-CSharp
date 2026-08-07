using Exercicio_01;
using System.Globalization;


Retangulo Retangulo1 = new Retangulo();
Retangulo1.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Retangulo1.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Console.WriteLine("AREA: " + Retangulo1.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO: " + Retangulo1.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL: " + Retangulo1.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
