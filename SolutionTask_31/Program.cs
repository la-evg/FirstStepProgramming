//Переменные для накопления результата
int positivSum = 0;
int negativSum = 0;

//Метод возращает массив заполненный случайными числами от -9 до 9
int[] FillingArray()
{
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    // Буферная переменная
    int i = 0;
    //Выходной массив
    int[] outArray = new int[12];

    //Цикл заполнения массива
    while (i < 12)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(-9, 10);
        //Увеличиваем инкримент
        i++;
    }
    //Возвращаем переменную
    return outArray;
}

//Метод подсчета положительных и отрицательных чисел в массиве
void CalculateTask(int[] outArray)
{
    int i = 0;
    while (i < 12)
    {
        if (outArray[i] > 0)
        {
            positivSum++;
        }
        else
        {
            negativSum++;
        }

        i++;
    }
}

//Метод вывода на печать массива массиве
void PrintIntArray(int[] inputArray)
{   //Буферная переменная
    int i = 0;
    Console.Write("[");
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива на печать
        Console.Write(inputArray[i] + ", ");
        //Увеличиваем инкримент
        i++;
    }
    //Выводим последний элемент и закрываем скобку
    Console.WriteLine(inputArray[i] + "]");
}

//Метод вывода на печать
void PrintResult()
{
    Console.WriteLine(positivSum);
    Console.WriteLine(negativSum);
}

//Метод запуска методов
void VariantNative()
{
    int[] bufferArray = FillingArray();
    CalculateTask(bufferArray);
    PrintIntArray(bufferArray);
    PrintResult();
}

//Вызов метода старта
VariantNative();
