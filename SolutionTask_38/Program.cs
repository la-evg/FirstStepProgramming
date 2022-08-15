//Метод возращает массив заполненный случайными числами
int[] FillingArray()
{
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    // Буферная переменная
    int i = 0;
    //Выходной массив
    int[] outArray = new int[10];

    //Цикл заполнения массива
    while (i < outArray.Length)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(10, 100);
        //Увеличиваем инкримент
        i++;
    }
    //Возвращаем переменную
    return outArray;
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

//Метод вычисления разницы максимального и минимального элемента массива.
int CalculateTask(int[] inputArray)
{
    //Вводим переменную для максимального элемента
    int max = int.MinValue;
    //Вводим переменную для минимального элемента и присваеваем ему максимальное значение
    int min = int.MaxValue;
    //Вводим переменную для подсчета суммы
    int different = 0;
    //Буферная переменная с 1 нечетного индекса
    int i = 0;
    //Проходим по всем элементам массива
    while (i < inputArray.Length)
    {
        //Если данный элемент больше max, то присваиваем ему это значение
        if (inputArray[i] > max)
        {
            max = inputArray[i];
        }
        //Если данный элемент меньше min, то присваиваем ему это значение
        if (inputArray[i] < min)
        {
            min = inputArray[i];
        }
        i++;
    }
    Console.WriteLine($"Максимальный элемент массива: {max}, а минимальный {min}");
    //Возвращаем разницу элементов
    return (max-min);
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine("Разница элементов равна: " + CalculateTask(buferArray));
