using System;
using System.Collections.Generic;
using System.Text;
// Exemplos usando This

namespace Aula_05
{
    public  class Produto
    {
        public string Nome { get; set; }
        public string Observacao { get; set; }
        public int QuantidadeEstoque { get; set; }

        

        // Geralmente os parametros sao com letra minuscula mas nesse exemplo os parametros sao com letra maisucula para usar o
        // This para diferenciar o parametro do atributo para o sistema conseguir diferenciar
        public Produto(string Nome , string Observacao)
        {
            this.Nome = Nome;
            this.Observacao = Observacao;
        }


        // Chamando outro contrutor para esse usando this, ele nao herda automaticamente os 
        // atributos do outro construtor tem que informar qual voce deseja e passa como parametros

        public Produto (string nome , string observacao ,int quantidadeEstoque) : this(nome, observacao)
        {
            QuantidadeEstoque = quantidadeEstoque;
        }
        // Outra forma é na propi class chmar o propio method como argumento na intancia do objeto
    }
}
