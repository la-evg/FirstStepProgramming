/* 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
 */

Console.Clear();

//Метод чтения количества чисел для ввода
int[] ReadLengthArr()
{
    int[] arrSize = new int[2];
    Console.Write("Введите колличество строк: ");
    arrSize[0] = int.Parse(Console.ReadLine());
    Console.Write("Введите колличество столбцов: ");
    arrSize[1] = int.Parse(Console.ReadLine());
    return arrSize;
}

// Метод генерации двумерного рандомного массива из входных параметров
int[,] GenerateArray(int[] size)
{
    System.Random numberSintezator = new System.Random();
    int[,] genArr = new int[size[0], size[1]];
    for (int i = 0; i < size[0]; i++)
    {
        for (int j = 0; j < size[1]; j++)
        {
            genArr[i, j] = numberSintezator.Next(10, 100);
        }
    }
    return genArr;
}

//Метод для вывода двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        Console.Write("[");
        while (j < inputArray.GetLength(1) - 1)
        {
            Console.Write(inputArray[i, j] + ", ");
            j++;
        }
        //Console.Write("\n");
        Console.Write(inputArray[i, j]);
        Console.Write("]");
        Console.WriteLine();
        i++;
    }
}

//Метод чтения индеков для поиска элемента
int[] ReadForSearch()
{
    int[] arrElement = new int[2];
    Console.Write("Введите индекс строки для поиска: ");
    arrElement[0] = int.Parse(Console.ReadLine());
    Console.Write("Введите индекс столбца для поиска: ");
    arrElement[1] = int.Parse(Console.ReadLine());
    return arrElement;
}

//Поиск элемента в  массиве
void Search(int[,] inputArray, int[] element)
{
    if (inputArray.GetLength(0) > element[0] && inputArray.GetLength(1) > element[1])
    {
        Console.WriteLine($"Элемент с индексами {element[0]},{element[1]} есть в массиве. Это число {inputArray[element[0], element[1]]}");
    }
    else
    {
        Console.WriteLine($"Элемент с индексами {element[0]},{element[1]} в массиве нет");
    }
}


int[,] genArray = GenerateArray(ReadLengthArr());
PrintTwoDimArray(genArray);
Search(genArray, ReadForSearch());