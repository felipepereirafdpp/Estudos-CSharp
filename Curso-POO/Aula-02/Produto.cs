using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_02
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public double ValorTotalEmEstoque()
        {
            double valorTotal = Preco * Quantidade;
            return valorTotal;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;

        }
        public void RemoveProdutos(int quantidade)
        {
            Quantidade -= quantidade;

        }
    }
}
