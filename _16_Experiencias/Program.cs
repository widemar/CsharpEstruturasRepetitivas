using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Quantos casos de teste serão digitados: ");
int qtdDeTestes = int.Parse(Console.ReadLine()!);

int contaCoelhos = 0, contaRatos = 0, contaSapos = 0;
for (int i = 0; i < qtdDeTestes; i++)
{
    Console.Write("Quantidade de cobaias: ");
    int qtdCobaias = int.Parse(Console.ReadLine()!);
    Console.Write("Tipo de cobaia: ");
    char tipoDeCobaia = char.Parse(Console.ReadLine()!.ToUpper());

    switch (tipoDeCobaia)
    {
        case 'C':
            contaCoelhos += qtdCobaias;
            break;
        case 'R':
            contaRatos += qtdCobaias;
            break;
        case 'S':
            contaSapos += qtdCobaias;
            break;
        default:
            Console.WriteLine("Cobaia Inválida");
            break;
    }
}

int totalCobaias = contaCoelhos + contaRatos + contaSapos;
double percentualDeCoelhos = contaCoelhos / (double)totalCobaias * 100;
double percentualDeRatos = contaRatos / (double)totalCobaias * 100;
double percentualDeSapos = contaSapos / (double)totalCobaias * 100;

Console.WriteLine($"Total: {totalCobaias}");
Console.WriteLine($"Total de coelhos: {contaCoelhos}");
Console.WriteLine($"Total de ratos: {contaRatos}");
Console.WriteLine($"Total de sapos: {contaSapos}");
Console.WriteLine($"Percentual de coelhos: {percentualDeCoelhos.ToString("F2", info)}");
Console.WriteLine($"Percentual de ratos: {percentualDeRatos.ToString("F2", info)}");
Console.WriteLine($"Percentual de sapos: {percentualDeSapos.ToString("F2", info)}");