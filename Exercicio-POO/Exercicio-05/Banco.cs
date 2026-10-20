using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_05
{
    public class Banco
    {
        public Banco(string numeroConta, string nome)
        {
            _numeroConta = numeroConta;
            Nome = nome;
           
        }

        private string _numeroConta { get; set; }
        public string Nome { get; set; }

        public decimal SaldoConta { get; private set; }


        public string NumeroConta {
            get { return _numeroConta; }

        }
        public string AtualziarNome
        {
            set
            {
                if (! string.IsNullOrWhiteSpace(value) && value != Nome && value.Length < 2)
                {
                    Nome = value;
                }


            }

        }

        public void AdicionarDeposito(decimal valor)
        {
            if (valor > 0)
            {
                SaldoConta += valor;
            }
        }

        public void AdicionarSaque(decimal valor)
        {
            if (valor < 5)
            {
                valor += 5;

                SaldoConta -= valor;
            }
        }


    }
}
