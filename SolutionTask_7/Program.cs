String? InputNum = Console.ReadLine();

if(InputNum != null)
{
    if((int.Parse(InputNum) % 2) == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
