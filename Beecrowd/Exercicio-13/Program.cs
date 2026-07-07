
int produtoInformado, gasolina, alcool, dizel;
gasolina = 0;
alcool = 0;
dizel = 0;
produtoInformado = 0;




while (produtoInformado != 4)
{
    produtoInformado = int.Parse(Console.ReadLine());
    if (produtoInformado < 0 || produtoInformado > 4)
    {
        Console.WriteLine("Numero Invalido");
    }

    switch (produtoInformado)
    {
        case 1:
            alcool++;
            break;
        case 2:
            gasolina++;
            break;
        case 3:
            dizel++;
            break;


    }

}

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("ALCOOL: " + alcool);
Console.WriteLine("GASOLINA: " + gasolina);
Console.WriteLine("DIZEL: " + dizel);
