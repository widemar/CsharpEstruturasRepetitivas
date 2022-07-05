Console.Write("Quantos números você vai digitar: ");
int qtdNumeros = int.Parse(Console.ReadLine()!);

int contaDentro = 0, contaFora = 0;
for (int i = 0; i < qtdNumeros; i++)
{
    Console.Write("Digite um número: ");
    int num = int.Parse(Console.ReadLine()!);

    if (num is >= 10 and <= 20)
    {
        contaDentro++;
    }
    else
    {
        contaFora++;
    }
}

Console.WriteLine($"{contaDentro} DENTRO");
Console.WriteLine($"{contaFora} FORA");