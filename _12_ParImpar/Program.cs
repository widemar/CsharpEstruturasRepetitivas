Console.Write("Quantos números você vai digitar: ");
int qtdNumeros = int.Parse(Console.ReadLine()!);

for (int i = 0; i < qtdNumeros; i++)
{
    Console.Write("Digite um número: ");
    int num = int.Parse(Console.ReadLine()!);

    string mensagem;
    if (num == 0)
    {
        mensagem = "NULO";
    }
    else if (num % 2 == 0 && num > 0)
    {
        mensagem = "PAR POSITIVO";
    }
    else if (num % 2 == 0 && num < 0)
    {
        mensagem = "PAR NEGATIVO";
    }
    else if (num % 2 != 0 && num > 0)
    {
        mensagem = "ÍMPAR POSTIVO";
    }
    else
    {
        mensagem = "ÍMPAR NEGATIVO";
    }

    Console.WriteLine(mensagem);
}