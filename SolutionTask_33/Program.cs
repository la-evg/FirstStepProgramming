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

//Метод решения задачи 33 наивный
bool CalculateTask(int[] inputArray, int searchNumber)
{
    bool resultSearch = false;
    int i = 0;
    while (i < 12)
    {
        if (inputArray[i] == searchNumber)
        {
            resultSearch = true;
            break;
        }
        i++;
    }
    return resultSearch;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.Write("Введите число для поиска: ");
int searchNumber = int.Parse (Console.ReadLine());
Console.WriteLine(CalculateTask(buferArray, searchNumber));