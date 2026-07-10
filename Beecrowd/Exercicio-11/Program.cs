

int x;
string[] nomes;

Console.Write("Informe a quantidade de nomes que vai ser inserido: ");
x = int.Parse(Console.ReadLine());

nomes = new string[x];


for (int i = 0; i < nomes.Length; i++)
{
    string nome = Console.ReadLine();
    nomes[i] = nome;

}
Console.WriteLine("Nomes Lidos: ");
foreach (string pessoa in nomes)
{
    
    Console.WriteLine(pessoa);
}