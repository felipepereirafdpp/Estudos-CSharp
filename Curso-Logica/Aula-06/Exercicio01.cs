using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_06
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int x = int.Parse(Console.ReadLine());
            int numero = 0;

            if (x % 2 == 0)
            {
                x++;
            }

            for (int i = 0; i < 6; i++)
            {

                Console.WriteLine(x);
                x += 2;
                

            }
        }
    }
}
