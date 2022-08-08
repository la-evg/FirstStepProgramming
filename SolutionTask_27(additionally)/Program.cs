Console.Clear();
Console.Write("Введите число: ");
//Обьявляем переменные
string inputLine = Console.ReadLine();
long sum;
int timeStart, timeStop;

//Вариант с циклом
void FirstVariant()
{
    timeStart = System.Environment.TickCount;
    sum = 0;
    long inputNumber = long.Parse(inputLine);
    while (inputNumber > 10)
    {
        sum = sum + inputNumber % 10;
        inputNumber /= 10;
    }
    sum += inputNumber;
    timeStop = System.Environment.TickCount;
    Console.WriteLine($"Сумма чисел в {inputLine} равна {sum}. Это заняло: {timeStop - timeStart}");
}
//Вариант с переводом в массив
void SecondVariant()
{
    timeStart = System.Environment.TickCount;
    sum = 0;
    int i = 0;
    char[] numArr = inputLine.ToCharArray();
    while (i < numArr.Length)
    {
        sum = sum + (int)Char.GetNumericValue(numArr[i]);
        i++;
    }
    timeStop = System.Environment.TickCount;
    Console.WriteLine($"Сумма чисел в {inputLine} равна {sum}. Это заняло: {timeStop - timeStart}");
}


Console.WriteLine("-----Первый вариант-----");
FirstVariant();
Console.WriteLine("-----Первый вариант-----");
SecondVariant();