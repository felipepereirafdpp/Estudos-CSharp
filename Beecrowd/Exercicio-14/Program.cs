
int golInter, golGremio, TotalPartida, vitoriasGremio , vitoriaInter, empates;
vitoriaInter = 0;
vitoriasGremio = 0;
empates = 0;
TotalPartida = 1;

string maiorVencedor = "";

Console.WriteLine("Informe o placar (inter) x (gremio): ");
string ResultadoPartida = Console.ReadLine();
string[] vet = ResultadoPartida.Split(" ");
golInter = int.Parse(vet[0]);
golGremio = int.Parse(vet[1]);
if (golInter > golGremio)
{
    vitoriaInter++;
}
else if (golInter == golGremio)
{
    empates++;
}
else
{
    vitoriasGremio++;
}

Console.WriteLine("Nova Partida 1:(sim) x 2(não): ");

int criarNovaPartida = int.Parse(Console.ReadLine());

while(criarNovaPartida != 2)
{
    TotalPartida++;

    Console.WriteLine("Informe o placar (inter) x (gremio): ");
    string ResultadoPartidas = Console.ReadLine();
    string[] vetor = ResultadoPartidas.Split(" ");
    golInter = int.Parse(vetor[0]);
    golGremio = int.Parse(vetor[1]);
    if (golInter > golGremio)
    {
        vitoriaInter++;
    }
    else if (golInter == golGremio)
    {
        empates++;
    }
    else
    {
        vitoriasGremio++;
    }

    Console.WriteLine("Nova Partida 1:(sim) x 2(não): ");

     criarNovaPartida = int.Parse(Console.ReadLine());
}
if (vitoriaInter > vitoriasGremio)
{
    maiorVencedor = "Internacional venceu mais classicos";
}else if (vitoriasGremio > vitoriaInter)
{
    maiorVencedor = "Gremio venceu mais classicos";
}
else
{
    maiorVencedor = "Houve empate em vitorias";
}
Console.WriteLine("Total de Jogos: " + TotalPartida);
Console.WriteLine("Vitoria Gremio: " + vitoriasGremio);
Console.WriteLine("Vitoria Internacional: " + vitoriaInter);
Console.WriteLine("Empates: " + empates);
Console.WriteLine("Maior vencedor: " + maiorVencedor);