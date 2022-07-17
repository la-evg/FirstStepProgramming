Console.Clear();

void SearchSecondNumber()
{
    Console.Write("Введите трёхзначное число: ");
    string? inputLine = Console.ReadLine();
    if (inputLine != null)
    {
        int inputNumber = Math.Abs(int.Parse(inputLine));
        if (inputNumber.ToString().Length != 3)
        {
            Console.WriteLine("Это не трехзначное число. Попробуй снова");
            SearchSecondNumber();
        }
        else
        {
            char[] numArr = inputNumber.ToString().ToCharArray();
            Console.Write("Вторая цифра = ");
            Console.Write(numArr[1]);
        }
    }
}
SearchSecondNumber();
