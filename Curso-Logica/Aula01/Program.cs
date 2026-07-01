
using System.Globalization;

string frase= Console.ReadLine();

string p1 = Console.ReadLine();
string p2 = Console.ReadLine();
string p3 = Console.ReadLine();
string s = Console.ReadLine();

string[] vet = s.Split(" ");
string a = vet[0];
string b = vet[1];
string c = vet[2];

Console.WriteLine("|-----------------------------------------------------------|");
Console.WriteLine("Voce Digitou: ");
Console.WriteLine(frase);
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);
Console.Write(a + " ");
Console.Write(b + " ");
Console.WriteLine(c);
