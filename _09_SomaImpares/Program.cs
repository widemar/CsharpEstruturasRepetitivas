Console.WriteLine("Digite dois números: ");
int numUm = int.Parse(Console.ReadLine()!);
int numDois = int.Parse(Console.ReadLine()!);

int min = Math.Min(numUm, numDois);
int max = Math.Max(numUm, numDois);
int somaImpares = 0;
for (int i = min + 1; i < max; i++)
{
    if (i % 2 != 0)
    {
        somaImpares += i;
    }
}

Console.WriteLine($"SOMA ÍMPARES = {somaImpares}");