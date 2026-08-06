
//Usando POO nesse projeto

namespace Aula_01
{
    
    public class Triangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public double CalularAreaTriangulo()
        {
            double p = (LadoA + LadoB + LadoC) / 2.00;
            double areaTriangulo = Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));

            return areaTriangulo;
        }

    }
   
        

}
