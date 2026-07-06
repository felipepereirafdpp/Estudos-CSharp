// Aula de Estrtura Repetitiva "Enquanto"   
using Aula_05;

int numero, resultado;
resultado = 0;

numero = int.Parse(Console.ReadLine());

while (numero != 0) // Enquanto o numeor informado for difernete de 0 vai entrar no While
{
    resultado += numero;
    numero = int.Parse(Console.ReadLine());

}
Console.WriteLine(resultado);


Console.WriteLine("|----------------------Exercicio 01----------------------|");

Exercicio01 exercicio = new Exercicio01();
exercicio.Executar();

Console.WriteLine("|----------------------Exercicio 02----------------------|");
Exercicio02 exercicio2 = new Exercicio02();
exercicio2.Executar();

Console.ReadLine();