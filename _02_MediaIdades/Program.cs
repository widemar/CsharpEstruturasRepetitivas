using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

int idade;
int somaIdades = 0;
int qtdIdades = 0;
Console.WriteLine("Digite as idades:");
do
{
    idade = int.Parse(Console.ReadLine()!);
    if (idade < 0 && qtdIdades == 0)
    {
        Console.WriteLine("IMPOSSÍVEL CALCULAR");
    }
    else if (idade > 0)
    {
        somaIdades += idade;
        qtdIdades++;
    }
} while (idade > 0);

double mediaIdades = (double)somaIdades / qtdIdades;
if (qtdIdades > 0)
{
    Console.WriteLine($"MEDIA = {mediaIdades.ToString("F2", info)}"); 
}
