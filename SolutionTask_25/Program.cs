Console.Clear();

//Обьявляем глобальные переменные
int inputNumber;
int inputPow;

//Обьявляем переменную для подсчета времени выполнения
DateTime timePoint = DateTime.Now;

void ReadNumbers()
{
    //Принимаем число
    Console.Write("Введите число: ");
    inputNumber = int.Parse(Console.ReadLine());

    //Принимаем степень
    Console.Write("Введите степень: ");
    inputPow = int.Parse(Console.ReadLine());
}

int VariantMath()
{
    int result = (int)Math.Pow(inputNumber, inputPow);
    return result;
}

int VariantFor()
{
    int result = 1;
    for (int i = 0; i < inputPow; i++)
    {
        result *= inputNumber;
    }
    return result;
}

void PrintResult()
{
    Console.WriteLine("-----Первый вариант-----");
    timePoint = DateTime.Now;
    Console.WriteLine($"Число {inputNumber} в степени {inputPow} равно: {VariantMath()}");
    Console.WriteLine("Время выполнения: " + (DateTime.Now.Ticks - timePoint.Ticks));

    Console.WriteLine("-----Второй вариант-----");
    timePoint = DateTime.Now;
    Console.WriteLine($"Число {inputNumber} в степени {inputPow} равно: {VariantFor()}");
    Console.WriteLine("Время выполнения: " + (DateTime.Now.Ticks - timePoint.Ticks));
}
//Вызываем метод считывания переменных
ReadNumbers();
//Вызываем первый вариант
VariantMath();
//Вызываем второй
VariantFor();
//Вызываем метод вывода
PrintResult();
