int N;


N = int.Parse(Console.ReadLine());
string[] nome = new string[N];
int[] idade = new int[N];
int Maisvelho = idade[0];
string nomeMaisVelho = "";


for (int i = 0; i < N; i++)
{
    string[] dados = Console.ReadLine().Split(" ");
    nome[i] = dados[0];
    idade[i] = int.Parse(dados[1]);
    if (idade[i] > Maisvelho)
    {
        Maisvelho = idade[i];
        nomeMaisVelho = nome[i];
    }
}
Console.WriteLine("Pessoa mais velha: "+nomeMaisVelho);