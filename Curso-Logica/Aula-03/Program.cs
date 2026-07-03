using Aula_03;
// Estrtura Condicional 
//Aula que ja dominio o conceito explicado , colocar algum exemplo simples


// Estrtura Condicional Simples
Console.WriteLine("|----------------------Estrutura Condicional Simples----------------------|");
int x = 5;

Console.WriteLine("Bom Dia !");

if (x >= 05) //Só vai ser escrito no console o "Boa Tarde" caso essa condição for verdadeira.
{
    Console.WriteLine("Boa Tarde !");
}

Console.WriteLine("Boa Noite!");


// Estrutura Condicional Composta , onde adiciona o else 
Console.WriteLine("|----------------------Estrutura Condicional Composta----------------------|");
Console.WriteLine("Informe um numero: ");

int numero = int.Parse(Console.ReadLine());
var message = "";

if (numero % 2 == 0)
{
    message = "Par";
}
else
{
    message = "Impar";
}
Console.WriteLine(message);


Console.WriteLine("|----------------------Estrutura Condicional Composta Com Encadeamento----------------------|");
Console.WriteLine("Informe o Horario: ");

int horas = int.Parse(Console.ReadLine());
var mensagem = "";
if (horas < 12)
{
    mensagem = "Bom Dia!";
}
else if (horas < 18)
{
    mensagem = "Boa Tarde!";
}
else
{
    mensagem = "Boa Noite!";
}
Console.WriteLine(mensagem);




Console.WriteLine("|----------------------EXERCICIO 01----------------------|");
Exercicio01 exercicio01 = new Exercicio01();
exercicio01.Executar();

Console.WriteLine("|----------------------EXERCICIO 02----------------------|");
Exercicio02 exercicio02 = new Exercicio02();
exercicio02.Executar();



Console.WriteLine("|----------------------EXERCICIO 03----------------------|");
Exercicio03 exercicio03 = new Exercicio03();
exercicio03.Executar();




Console.ReadLine();