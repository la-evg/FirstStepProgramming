//Метод возращает массив заполненный случайными числами
int[] FillingArray()
{
    //Создаем экземпляр класса рандомайзер
    System.Random numberSintezator = new System.Random();
    // Буферная переменная
    int i = 0;
    //Выходной массив
    int[] outArray = new int[123];

    //Цикл заполнения массива
    while (i < 123)
    {
        //Получаем новое значение
        outArray[i] = numberSintezator.Next(-1000, 1000);
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

//Метод решения задачи 37 наивный
int[] CalculateTask(int[] inputArray)
{
    int[] resultArray = new int[inputArray.Length / 2 + 1];
    int i = 0;
    while (i < resultArray.Length)
    {
        resultArray[i] = inputArray[i] * inputArray[inputArray.Length - 1 - i];
        i++;
    }

    return resultArray;

}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
int[] resultArray = CalculateTask(buferArray);
PrintIntArray(resultArray);
