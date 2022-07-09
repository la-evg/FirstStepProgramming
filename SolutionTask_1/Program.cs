String? InputOneNum = Console.ReadLine();
String? InputTwoNum = Console.ReadLine();

if(InputOneNum != null && InputTwoNum != null)
{
    int OneNum = int.Parse(InputOneNum);
    int TwoNum = int.Parse(InputTwoNum);

    if(TwoNum == Math.Sqrt(OneNum))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}
