bool coordenadaValida = true;

while (coordenadaValida)
{
    Console.WriteLine("Digite os valores das coordenadas X e Y: ");
    int x = int.Parse(Console.ReadLine()!);
    int y = int.Parse(Console.ReadLine()!);

    string mensagem = "";
    if (x == 0 || y == 0)
    {
        coordenadaValida = false;
    }
    else
        mensagem = x switch
        {
            > 0 when y > 0 => "Quadrante Q1",
            < 0 when y > 0 => "Quadrante Q2",
            < 0 when y < 0 => "Quadrante Q3",
            _ => "Quadrante Q4"
        };

    Console.WriteLine(mensagem);
}