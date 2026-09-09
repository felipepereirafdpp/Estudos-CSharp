using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_06
{
    public class Produto
    {
        // usando _nomeDoAtributo pois a convesão do c# para atributos privados é assim, atributos privados são acessados somente dentro da propia classe
        private string _nome { get; set; }
        private int _quantidade { get; set; }

       

        public Produto(string nome, int quantidade)
        {
            _nome = nome;
            _quantidade = quantidade;
        }

        // Deixando o nome acessivel para os outros lugares do codigo 
        public string GetNome()
        {
            return _nome;
        }

        // Deixando o nome acessivel paar edição do nome de outro lugares do codigo| podendo icluir logica de validação
        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome) || nome.Length < 2)
            {
                throw new ArgumentException("Nome invalido");
            }
            _nome = nome;
            
        }

        // NAO DEIXEI PUBLICO PARA ADICONAR QUANTIADE NO ESTOQUE 
        public void AdicionarEstoque(int quantidade)
        {
            _quantidade = +quantidade;
        }

        // SOMENTE PUBLICO A PARTE DE EXIBIR A QUANTIDADE QUE TEM NO ESTOQUE
        public int Quantidade()
        {
            return _quantidade;
        }
    }
}
 
 