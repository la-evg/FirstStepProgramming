Console.Write("Введите число: ");
string? inputCount = Console.ReadLine();
//Метод считающий и выводящий значения чисел и их кубов
void numInCube(int count)
{
    //Обьявление строк и счетчика
    string LineNum = string.Empty;
    string LineNumInCube = string.Empty;
    //Обьявление строк и счетчика
    int i = 1;
    while (i <= count)
    {   
        //Формирование строки из чисел
        LineNum = LineNum + i + " ";
        //Формирование строки из кубов
        LineNumInCube = LineNumInCube + Math.Pow(i, 3).ToString() + " ";
        i++;
    }
    Console.WriteLine("---Список чисел---");
    Console.WriteLine(LineNum);
    Console.WriteLine("---Список чисел в кубе---");
    Console.WriteLine(LineNumInCube);
}

//Проверка на пустую строку и значения в ней.
if (inputCount != null && int.Parse(inputCount) >= 1)
{
    int count = int.Parse(inputCount);
    //Вызов метода
    numInCube(count);
}