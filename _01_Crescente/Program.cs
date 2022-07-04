int numUm;
int numDois;
do
{
    Console.WriteLine("Digite dois números: ");
    numUm = int.Parse(Console.ReadLine()!);
    numDois = int.Parse(Console.ReadLine()!);

    if (numUm > numDois)
    {
        Console.WriteLine("DECRESCENTE!");
    }
    else if (numUm < numDois)
    {
        Console.WriteLine("CRESCENTE!");
    }
} while (numUm != numDois);