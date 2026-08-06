using System.Globalization;

// Resolvendo um problema sem utilizar Programação Orientada Objetos

namespace Aula_01
{
    public class Exercicio01SemPOO
    {
        public void Executar()
        {
            double x1,x2,x3 , y1,y2,y3;
            Console.WriteLine("Entre com as Medidas do triangulo X: ");
            string[] valoresTrianguloX = Console.ReadLine().Split(" ");

            x1 = double.Parse(valoresTrianguloX[0],CultureInfo.InvariantCulture);
            x2 = double.Parse(valoresTrianguloX[1], CultureInfo.InvariantCulture);
            x3 = double.Parse(valoresTrianguloX[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as Medidas do triangulo Y: ");
            string[] valoresTrianguloY = Console.ReadLine().Split(" ");
            y1 = double.Parse(valoresTrianguloY[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(valoresTrianguloY[1], CultureInfo.InvariantCulture);
            y3 = double.Parse(valoresTrianguloY[2], CultureInfo.InvariantCulture);


            double pX = (x1 + x2 + x3) / 2.0;
            double areaTrianguloX = Math.Sqrt(pX * (pX - x1) * (pX - x2) * (pX - x3));

            double pY = (y1 + y2 + y3) / 2.0;
            double areaTrianguloY = Math.Sqrt(pY * (pY - y1) * (pY - y2) * (pY - y3));

            Console.WriteLine("Área de X: " + areaTrianguloX.ToString("F4"),CultureInfo.InvariantCulture);
            Console.WriteLine("Área de Y: " + areaTrianguloY.ToString("F4"), CultureInfo.InvariantCulture);

            string sigla;
            if(areaTrianguloX > areaTrianguloY)
            {
                sigla = "X";
            }
            else
            {
                sigla = "Y";
            }

            Console.WriteLine("Maior Área: " + sigla);
        }
    }
}
