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

//Метод вычисления суммы элементов, стоящих на нечётных позициях.
int CalculateTask(int[] inputArray)
{
    //Вводим переменную для подсчета суммы
    int sum = 0;
    //Буферная переменная с 1 нечетного индекса
    int i = 1;
    //Проходим по всем элементам массива
    while (i < inputArray.Length)
    {
        //В переменную суммы прибавляем значение элемента массива
        sum +=inputArray[i];
        //Увеличиваем инкримент на 2
        i+=2;
    }
    //Возвращаем сумму
    return sum;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.WriteLine(CalculateTask(buferArray));
