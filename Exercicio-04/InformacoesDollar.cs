using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_04
{
    public class InformacoesDollar
    {

     

        public static double CalcularValorDollar(double valor , double cotacaoDollar)
        {
            return ((valor * cotacaoDollar) * 1.06 );
        }

    }
}
