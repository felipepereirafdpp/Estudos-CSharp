using Exercicio_05;
using System.Globalization;

Console.Write("Entre o número da conta: ");
 string numeroConta = Console.ReadLine();

Console.Write("Entre o titular da conta: ");
 string nomeTitular = Console.ReadLine();

Console.Write("Havera deposito incial (s/n): ");
 string  resposta = Console.ReadLine();

decimal valorDeposito = 0;
decimal valorSaque = 0;

if (resposta == "s")
{
    Console.Write("Valor Deposito: ");
    valorDeposito = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

}


Banco banco = new Banco(numeroConta, nomeTitular);
banco.AdicionarDeposito(valorDeposito);

Console.WriteLine("");

Console.WriteLine("Dados da Conta");
Console.WriteLine("Conta: " + banco.NumeroConta + ", " + "Titular: " + banco.Nome + ", " + "Saldo: $" + banco.SaldoConta.ToString("F2",CultureInfo.InvariantCulture));


Console.WriteLine("");

Console.Write("Entre com valor para Deposito: ");
valorDeposito = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
banco.AdicionarDeposito(valorDeposito);
Console.WriteLine("Dados da Conta Atualizados");
Console.WriteLine("Conta: " + banco.NumeroConta + ", " + "Titular: " + banco.Nome + ", " + "Saldo: $" + banco.SaldoConta.ToString("F2", CultureInfo.InvariantCulture));


Console.WriteLine("");

Console.Write("Entre com valor para saque: ");
valorSaque = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
banco.AdicionarSaque(valorSaque);
Console.WriteLine("Dados da Conta Atualizados");
Console.WriteLine("Conta: " + banco.NumeroConta + ", " + "Titular: " + banco.Nome + ", " + "Saldo: $" + banco.SaldoConta.ToString("F2", CultureInfo.InvariantCulture));



