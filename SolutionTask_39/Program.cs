//Метод возращает массив заполненный случайными числами
int[] FillingArray(int arrSize, int arrFrom, int arrTo)
{
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    // Буферная переменная
    int i = 0;
    //Выходной массив
    int[] outArray = new int[arrSize];

    //Цикл заполнения массива
    while (i < outArray.Length)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(arrFrom, arrTo);
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

//Метод реверса массива
int[] ReversArrayNew(int[] inputArray)
{
    int lenght = inputArray.Length;
    int[] reversArray = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        reversArray[lenght - 1 -i] = inputArray[i];
    }
    return reversArray;
}

int[] buferArray = FillingArray(10, 0, 15);
PrintIntArray(buferArray);
buferArray = ReversArrayNew(buferArray);
PrintIntArray(buferArray);