int x, y;
string sequencia;
sequencia = Console.ReadLine();

string[] vetor = sequencia.Split(" ");

x = int.Parse(vetor[0]);
y = int.Parse(vetor[1]);

while(x != y)
{
    
    if (x < y)
    {
        Console.WriteLine("Decresente");
    }
    else
    {
        Console.WriteLine("Cresente");
    }


    sequencia = Console.ReadLine();
    vetor = sequencia.Split(" ");
    x = int.Parse(vetor[0]);
    y = int.Parse(vetor[1]);
}

