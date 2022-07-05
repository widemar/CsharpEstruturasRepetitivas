bool diferenteDeZero = true;


while (diferenteDeZero)
{
    Console.Write("Digite um número inteiro: ");
    int num = int.Parse(Console.ReadLine()!);

    if (num == 0)
    {
        diferenteDeZero = false;
    }
    else
    {
        int qtdRepeticoes = 0;
        int soma = 0;
        while (qtdRepeticoes < 5)
        {
            if (num % 2 == 0)
            {
                soma += num;
                qtdRepeticoes++;
            }
            num++;
        }

        Console.WriteLine($"SOMA {soma}");
    }
}