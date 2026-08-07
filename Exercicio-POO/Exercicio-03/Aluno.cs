using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio_03
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double NotaPrimeiroTrimestre { get; set; }
        public double NotaSegundoTrimestre { get; set; }
        public double NotaTerceiroTrimestre { get; set; }

        
        public void CalcularSituaçãoAluno()
        {
            double NotaFinal = NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre;
            Console.WriteLine("Nota Final: " + NotaFinal.ToString("F2",CultureInfo.InvariantCulture));
            if (NotaFinal >= 60)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                NotaFinal -= 60;
                Console.WriteLine("FALTOU: " + NotaFinal);
            }
        }
        
    }
}
