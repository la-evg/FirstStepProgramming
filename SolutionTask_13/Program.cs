Console.Clear();

void SearchThirdNumber()
{
    Console.Write("Введите число: ");
    string? inputLine = Console.ReadLine();
    if (inputLine != null)
    {
        int inputNumber = Math.Abs(int.Parse(inputLine));
        if (inputNumber.ToString().Length <= 2)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else
        {
            char[] numArr = inputNumber.ToString().ToCharArray();
            Console.Write("Третья цифра = " + numArr[2]);
        }
    }
}
SearchThirdNumber();
