using Aula_01;
using System.Globalization;
// Modelo usando Split somente com string 
string frase = Console.ReadLine();
string x = Console.ReadLine();
string y = Console.ReadLine();
string z = Console.ReadLine();
string s = Console.ReadLine();
string[] palavras = s.Split(" ");

string a = palavras[0];
string b = palavras[1];
string c = palavras[2];

Console.WriteLine("|------------------Modelo--------------------|");
Console.WriteLine(frase);
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.Write(a + " ");
Console.Write(b + " ");
Console.Write(c);

// Modelo usando Split com diferentes tipos de variaveis 

String texto = Console.ReadLine();
String[] vetor = texto.Split(" ");
string nome = vetor[0];
char sexo = char.Parse(vetor[1]);
int idade = int.Parse(vetor[2]);
double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

Console.WriteLine("Olá " + nome + " você é do sexo " + sexo + " tem " + idade + " anos e mede " + altura.ToString("F2", CultureInfo.InvariantCulture) + " de altura");



Console.WriteLine("|-----------------Exercicio 01---------------------|");
Exercicio01 exercicio = new Exercicio01();
exercicio.Executar();

Console.WriteLine("|-----------------Exercicio 02---------------------|");
Exercicio02 exercicio02 = new Exercicio02();
exercicio02.Executar();