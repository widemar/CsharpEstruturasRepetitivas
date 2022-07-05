bool diferenteDeQuatro = true;

int contaAlcool = 0, contaGasolina = 0, contaDiesel = 0;
while (diferenteDeQuatro)
{
    Console.Write("Informe um código (1, 2, 3) ou 4 para parar: ");
    int codigo = int.Parse(Console.ReadLine()!);

    switch (codigo)
    {
        case < 0:
        case > 4:
            continue;
        case 4:
            diferenteDeQuatro = false;
            break;
        case 1:
            contaAlcool++;
            break;
        case 2:
            contaGasolina++;
            break;
        case 3:
            contaDiesel++;
            break;
    }
}

Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine($"Alcool: {contaAlcool}");
Console.WriteLine($"Gasolina: {contaGasolina}");
Console.WriteLine($"Diesel: {contaDiesel}");