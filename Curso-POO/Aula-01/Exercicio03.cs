using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_01
{
    public class Pessoa 
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string CalcularIdade(Pessoa pessoaA,Pessoa pessoaB)
        {
            string msg;

            if (pessoaA.Idade > pessoaB.Idade)
            {
                 msg = "Pessoa mais velha: " + pessoaA.Nome;
            }
            else
            {
                msg = "Pessoa mais velha: " + pessoaB.Nome;
            }

            return msg;
        }
    }
}
