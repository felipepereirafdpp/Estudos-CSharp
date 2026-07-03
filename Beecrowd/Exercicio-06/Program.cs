

int numeroProduto = int.Parse(Console.ReadLine());


int caixa = 100;
int x = numeroProduto / caixa;
Console.WriteLine(x + " Caixa de 100");
int resto = numeroProduto % caixa;

int caixa2 = 50;
int x2 = resto / caixa2;
Console.WriteLine(x2 + " Caixa de 50");
int resto2 = resto % caixa2;

int caixa3 = 20;
int x3 = resto2 / caixa3;
Console.WriteLine(x3 + " Caixa de 20");
int resto3 = resto2 % caixa3;


int caixa4 = 10;
int x4 = resto3 / caixa4;
Console.WriteLine(x4 + " Caixa de 10");
int resto4 = resto3 % caixa4;

int caixa5 = 5;
int x5 = resto4 / caixa5;
Console.WriteLine(x5 + " Caixa de 5");
int resto5 = resto4 % caixa5;

int caixa6 = 1;
int x6 = resto5 / caixa6;
Console.WriteLine(x6 + " Caixa de 1");

