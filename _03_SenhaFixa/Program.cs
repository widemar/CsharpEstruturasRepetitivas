bool senhaInvalida = true;

while (senhaInvalida)
{
    Console.Write("Digite a senha: ");
    int senha = int.Parse(Console.ReadLine()!);

    while (senha != 2002)
    {
        Console.WriteLine("Senha Inválida! Tente novamente: ");
        senha = int.Parse(Console.ReadLine()!);
    }

    Console.WriteLine("Acesso permitido!");
    senhaInvalida = false;
}