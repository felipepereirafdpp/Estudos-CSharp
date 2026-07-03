Console.WriteLine("Informe 3 numeros: ");
string numeros = Console.ReadLine();
string[] vetor = numeros.Split(" ");

int n1, n2, n3;

n1 = int.Parse(vetor[0]);
n2 = int.Parse(vetor[1]);
n3 = int.Parse(vetor[2]);

if (n1 <= n2 && n1 <= n3)
{
    Console.WriteLine("MENOR = "+n1);
}
else if ( n2 <= n3)
{
    Console.WriteLine("MENOR = "+n2);
}
else
{
    Console.WriteLine("MENOR = "+n3);
}