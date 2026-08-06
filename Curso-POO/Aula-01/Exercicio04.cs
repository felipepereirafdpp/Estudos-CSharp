using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_01
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }


        public double CalcularMediaSalarial(Funcionario pessoa1, Funcionario pessoa2)
        {
            return (pessoa1.Salario + pessoa2.Salario) / 2;
        }
    }
}
