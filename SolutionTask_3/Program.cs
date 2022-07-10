string? InputNumber = Console.ReadLine();

if(InputNumber != null)
{
    int InputNum = int.Parse(InputNumber);
    int StartNumber = 1;
    string LineOutput = "0";

    while (StartNumber <= InputNum)
    {
        LineOutput = StartNumber * (-1) + ", "+LineOutput+", " + StartNumber;
        StartNumber++;
    }

    Console.WriteLine(LineOutput);
}