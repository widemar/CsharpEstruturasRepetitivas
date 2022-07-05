using System.Globalization;

CultureInfo info = CultureInfo.InvariantCulture;

Console.Write("Qual a quantidade de atletas? ");
int qtdDeAtletas = int.Parse(Console.ReadLine()!);

double somaPesos = 0;
string nomeAtletaMaisAlto = "";
double alturaAtletaMaisAlto = 0;
int contaHomens = 0, contaMulheres = 0;
double somaAlturaMulheres = 0;
for (int i = 1; i <= qtdDeAtletas; i++)
{
    Console.WriteLine($"Digite os dados do atleta {i}:");
    Console.Write("Nome: ");
    string nome = Console.ReadLine()!;

    Console.Write("Sexo: ");
    char sexo = char.Parse(Console.ReadLine()!.ToUpper());
    while (sexo != 'M' && sexo != 'F')
    {
        Console.Write("Valor inválido! Favor digitar F ou M: ");
        sexo = char.Parse(Console.ReadLine()!.ToUpper());
    }

    Console.Write("Altura: ");
    double altura = double.Parse(Console.ReadLine()!, info);
    while (altura <= 0)
    {
        Console.Write("Valor inválido! Favor digitar um valor positivo: ");
        altura = double.Parse(Console.ReadLine()!, info);
    }

    if (altura > alturaAtletaMaisAlto)
    {
        nomeAtletaMaisAlto = nome;
        alturaAtletaMaisAlto = altura;
    }

    if (sexo == 'M')
    {
        contaHomens++;
    }
    else
    {
        contaMulheres++;
        somaAlturaMulheres += altura;
    }

    Console.Write("Peso: ");
    double peso = double.Parse(Console.ReadLine()!, info);
    while (peso <= 0)
    {
        Console.Write("Valor inválido! Favor digitar um valor positivo: ");
        peso = double.Parse(Console.ReadLine()!, info);
    }

    somaPesos += peso;
}

double pesoMedio = somaPesos / qtdDeAtletas;
double porcentagemDeHomens = (double)contaHomens / qtdDeAtletas * 100;

Console.WriteLine("RELATÓRIO:");
Console.WriteLine($"Peso médio dos atletas: {pesoMedio.ToString("F2", info)}");
Console.WriteLine($"Atleta mais alto: {nomeAtletaMaisAlto}");
Console.WriteLine($"Porcentagem de homens: {porcentagemDeHomens.ToString("F1", info)}%");
if (contaMulheres == 0)
{
    Console.WriteLine("Não há mulheres cadastradas.");
}
else
{
    double alturaMediaMulheres = somaAlturaMulheres / contaMulheres;
    Console.WriteLine($"Altura média das mulheres: {alturaMediaMulheres.ToString("F2", info)}");
}