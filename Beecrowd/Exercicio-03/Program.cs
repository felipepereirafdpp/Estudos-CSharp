

Console.WriteLine("Informe as notas: ");
string notas = Console.ReadLine();
string[] vetor = notas.Split(" ");

double notaA = double.Parse(vetor[0]) * 3.5;
double notaB = double.Parse(vetor[1]) * 7.5;

double respostaMedia = ((notaA + notaB) / 11);

Console.WriteLine("Media Ponterada: " + respostaMedia.ToString("F5"));



Console.WriteLine("|-------------------------Exercicio 2 de Media Ponderada-------------------------|");
Console.WriteLine("Informe as notas: ");
string frase = Console.ReadLine();
string[] notasArmazenadas = frase.Split(" ");
double nA = double.Parse(notasArmazenadas[0]) * 2;
double nB = double.Parse(notasArmazenadas[1]) * 3;
double nC = double.Parse(notasArmazenadas[2]) * 5;

double resultado = ((nA + nB + nC) / 10);
Console.WriteLine("Media Ponterada: " + resultado.ToString("F1"));