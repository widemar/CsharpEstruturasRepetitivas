Console.Write("Digite o valor de N: ");
int n = int.Parse(Console.ReadLine()!);

int fatorial = n;
if (fatorial == 0)
{
    fatorial = 1;
}
else
{
    for (int i = n - 1; i > 0; i--)
    {
        fatorial *= i;
    }
}

Console.WriteLine($"FATORIAL = {fatorial}");