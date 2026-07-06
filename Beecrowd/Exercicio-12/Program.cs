int senha;
senha = 0;


while (senha != 2002)
{
    senha = int.Parse(Console.ReadLine());
    if (senha != 2002)
    {
        Console.WriteLine("Senha Invalida");
    }
}
Console.WriteLine("Acesso Permitido");