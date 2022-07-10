string? InputFirstNumber = Console.ReadLine();
string? InputSecondNumber = Console.ReadLine();

if(InputFirstNumber != null && InputSecondNumber != null)
{
    if(int.Parse(InputFirstNumber) < int.Parse(InputSecondNumber))
    {
        Console.WriteLine(InputSecondNumber);
    }
    else
    {
        Console.WriteLine(InputFirstNumber);
    }
}