using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_05
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int numero, resultado, numeroMult;

            numeroMult = 0;

            Console.WriteLine("Informe a tabuada desejada: ");
            numero = int.Parse(Console.ReadLine());

            while(numeroMult <= 10)
            {

                resultado = numero * numeroMult;
              
                Console.WriteLine(numero + " X " + numeroMult + " = " + resultado);

                numeroMult++;
                
            }
        }
    }
}
