

Console.WriteLine("Informe o Numero de Registro: ");
string numeroRegistro = Console.ReadLine();
Console.WriteLine("Informe a quantide de Horas Trabalhadas: ");
double quantidaHorasTrabalhdas = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor da Hora do Funcionario: ");
double valorHora = double.Parse(Console.ReadLine());

var nome = "";
if (numeroRegistro == "324")
{
     nome = "Felipe de Paula Pereira";
}

double Salario = (quantidaHorasTrabalhdas * valorHora);

Console.WriteLine("Funcionario| " + nome + " | " + numeroRegistro);
Console.WriteLine("Salario: " + "R$"+Salario);