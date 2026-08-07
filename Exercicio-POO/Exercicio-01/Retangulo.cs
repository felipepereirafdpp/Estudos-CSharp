using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_01
{
    public class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Altura * Largura;
        }
        public double Perimetro()
        {
            return (Altura * 2) + (Largura * 2);
        }
        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura + Altura));
        }
    }
}
