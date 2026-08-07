using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_02
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            
            SalarioBruto += SalarioBruto * porcentagem / 100.0;
            
        }
    }
}
