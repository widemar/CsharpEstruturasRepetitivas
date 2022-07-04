using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Digite a primeira nota: ");
double notaUm = double.Parse(Console.ReadLine()!, info);
notaUm = VerificarIntervalo(notaUm);

Console.Write("Digite a segunda nota: ");
double notaDois = double.Parse(Console.ReadLine()!, info);
notaDois = VerificarIntervalo(notaDois);

double media = (notaUm + notaDois) / 2;
Console.WriteLine($"MEDIA = {media.ToString("F2", info)}");


double VerificarIntervalo(double nota)
{
    while (nota is < 0 or > 10)
    {
        Console.Write("Valor inválido! Tente novamente: ");
        nota = double.Parse(Console.ReadLine()!, info);
    }

    return nota;
}