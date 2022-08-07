Console.Clear();

//Обьявляем переменных
int inputFirstNumber;
string inputChar;
int inputSecondNumber;
int result;

void ReadNumbers()
{
    //Принимаем первое число
    Console.Write("Введите первое число: ");
    inputFirstNumber = int.Parse(Console.ReadLine());

    //Принимаем знак операции
    Console.Write("Введите знак вычисления: ");
    inputChar = Console.ReadLine();

    //Принимаем второе число
    Console.Write("Введите второе число: ");
    inputSecondNumber = int.Parse(Console.ReadLine());
}

//Описываем инструкцию каждой операции
int Sum()
{
    result = inputFirstNumber + inputSecondNumber;
    return result;
}

int Difference()
{
    result = inputFirstNumber - inputSecondNumber;
    return result;
}

int Multiplication()
{
    result = inputFirstNumber * inputSecondNumber;
    return result;
}

int Division()
{
    result = inputFirstNumber / inputSecondNumber;
    return result;
}

int Remainder()
{
    result = inputFirstNumber % inputSecondNumber;
    return result;
}

int Degree()
{
    result = (int)Math.Pow(inputFirstNumber, inputSecondNumber);
    return result;
}
//Проверяем знак операции и вызываем соответствующий метод
void Calculate()
{
    if (inputChar == "+")
    {
        Console.WriteLine($"{inputFirstNumber} {inputChar} {inputSecondNumber} = {Sum()}");
    }
    if (inputChar == "-")
    {
        Console.WriteLine($"{inputFirstNumber} {inputChar} {inputSecondNumber} = {Difference()}");
    }
    if (inputChar == "*")
    {
        Console.WriteLine($"{inputFirstNumber} {inputChar} {inputSecondNumber} = {Multiplication()}");
    }
    if (inputChar == "/")
    {
        Console.WriteLine($"{inputFirstNumber} {inputChar} {inputSecondNumber} = {Division()}");
    }
    if (inputChar == "%")
    {
        Console.WriteLine($"{inputFirstNumber} {inputChar} {inputSecondNumber} = {Remainder()}");
    }
    if (inputChar == "^")
    {
        Console.WriteLine($"{inputFirstNumber} {inputChar} {inputSecondNumber} = {Degree()}");
    }
    else{
        Console.WriteLine("Я знаю только: +, -, *, /, %, ^");
    }

}

//Вызов методов
ReadNumbers();
Calculate();