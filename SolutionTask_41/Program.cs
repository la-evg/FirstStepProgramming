//Подсчет положительных чисел, вводимых пользователем, с помощью массива.
Console.Clear();

//Метод чтения количества чисел для ввода
int ReadLengthArr()
{
    int sizeArray = 0;
    Console.Write("Введите колличество цифр: ");
    sizeArray = int.Parse(Console.ReadLine());
    return sizeArray;
}

//Метод для запроса чисел и генерации из них массива
int[] GenerateArray(int size)
{
    int[] genArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        genArr[i] = int.Parse(Console.ReadLine());
    }
    return genArr;
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

//Метод подсчета положительных чисел массива
int PositiveCount(int[] inputArray)
{
    int count=0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i] > 0){
           count++;
        }
    }
    return count;
}


int[] bufferArr = GenerateArray(ReadLengthArr());
PrintIntArray(bufferArr);
Console.WriteLine($"{PositiveCount(bufferArr)} положительных чисел в массиве.");