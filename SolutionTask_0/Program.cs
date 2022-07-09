string? InputLine = Console.ReadLine();

if(InputLine != null)
{
    int inputNumber = int.Parse(InputLine);
    //int outNumber = inputNumber * inputNumber;

    int outNumber = (int)Math.Pow(inputNumber,2);

    Console.WriteLine(outNumber);
}