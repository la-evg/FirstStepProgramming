string? InputNumber = Console.ReadLine();

if(InputNumber != null)
{
    string LastNum = InputNumber.Substring(InputNumber.Length-1);

    Console.WriteLine(int.Parse(LastNum));
}