

using System.Globalization;

int x;
double[] numeros;
double Somamedia = 0;
double media = 0;

x = int.Parse(Console.ReadLine());
numeros = new double[x];

string[] vet = Console.ReadLine().Split(" ");

for (int i = 0; i < x; i++) // Esse for adiciona os numeros no vetot
{
    numeros[i] = double.Parse(vet[i],CultureInfo.InvariantCulture);


}
for (int i = 0; i < numeros.Length; i++) // Esse for lista os numeros do vetor
{
    Console.Write(numeros[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
}

    for (int i = 0; i< numeros.Length; i++) // Esse for soma todos os numros que tem no vetor
{
    Somamedia += numeros[i];
    
}
media = (Somamedia / numeros.Length);
Console.WriteLine("Soma Total: "+Somamedia , CultureInfo.InvariantCulture);
Console.WriteLine("Media: " + media, CultureInfo.InvariantCulture);