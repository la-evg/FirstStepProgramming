//Метод возращает массив заполненный случайными числами от 100 до 1000
int[] FillingArray()
{
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    // Буферная переменная
    int i = 0;
    //Выходной массив
    int[] outArray = new int[15];

    //Цикл заполнения массива
    while (i < 15)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(100, 1000);
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

//Метод решения нахождения количества четных чисел массива
int CalculateTask(int[] inputArray)
{
    int resultCount = 0;
    int i = 0;
    while (i < inputArray.Length)
    {
        if (inputArray[i] % 2 == 0)
        {
            resultCount++;
        }
        i++;
    }
    return resultCount;
}


int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine(CalculateTask(buferArray));