using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_06
{
    public class Produto
    {
        // usando _nomeDoAtributo pois a convesão do c# para atributos privados é assim, atributos privados são acessados somente dentro da propia classe
        private string _nome { get; set; }
        public int Quantidade { get; private set ; } // Criando uma AUTOPROPETIS

        


        public Produto(string nome, int quantidade)
        {
            _nome = nome;
            Quantidade = quantidade;
        }

        // Deixando o nome acessivel para os outros lugares do codigo 
        public string GetNome()
        {
            return _nome;
        }

        // Criei uma Propetis para o get e set do nome para chamar de um jeit amigavell no c#
        public string Nome { 
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 2)
                {
                    _nome = value;
                }
            }
        }
       
       

            



        

  
    }
}
 
 