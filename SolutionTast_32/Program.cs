
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

//Метод подсчета положительных и отрицательных чисел в массиве
int[] CalculateTask(int[] inputArray)
{
    int[] outputArray = new int[12];
    int i = 0;
    while (i < 12)
    {
        outputArray[i] = inputArray[i] * (-1);
        i++;
    }
    return outputArray;
}

//Метод инвертирует элементы массива тильда
int[] InvertArrayTilda(int[] inputArray)
{
    //Буферная переменная
    int i = 0;
    //Пробегаем все элементы массива
    while (i < inputArray.Length)
    {
        //Инвертируем элемент
        inputArray[i] = (~inputArray[i]) + 1;
        //Увеличиваем инкримент
        i++;
    }
    //Возвращаем массив
    return inputArray;

}

int[] bufferArray = FillingArray();
PrintIntArray(bufferArray);
int[] resultArray = CalculateTask(bufferArray);
PrintIntArray(resultArray);
resultArray = InvertArrayTilda(bufferArray);
PrintIntArray(resultArray);


