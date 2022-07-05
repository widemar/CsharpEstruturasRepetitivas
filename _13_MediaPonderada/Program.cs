using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Quantos casos você vai digitar: ");
int qtdCasos = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite três números:");
for (int i = 0; i < qtdCasos; i++)
{
    double numUm = double.Parse(Console.ReadLine()!, info);
    double numDois = double.Parse(Console.ReadLine()!, info);
    double numTres = double.Parse(Console.ReadLine()!, info);

    double mediaPonderada = (numUm * 2 + numDois * 3 + numTres * 5) / 10;

    Console.WriteLine($"MEDIA = {mediaPonderada.ToString("F1", info)}");
}