using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Quantos casos você vai digitar: ");
int qtdCasos = int.Parse(Console.ReadLine()!);

for (int i = 0; i < qtdCasos; i++)
{
    Console.Write("Entre com o numerador: ");
    int numerador = int.Parse(Console.ReadLine()!);
    Console.Write("Entre com o denominador: ");
    int denominador = int.Parse(Console.ReadLine()!);

    if (denominador == 0)
    {
        Console.WriteLine("DIVISÃO IMPOSSÍVEL.");
    }
    else
    {
        double divisao = (double)numerador / denominador;
        Console.WriteLine($"DIVISÃO = {divisao.ToString("F2", info)}");
    }
}