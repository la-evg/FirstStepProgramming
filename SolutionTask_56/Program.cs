/*===========================================================
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов
============================================================ */
Console.Clear();

//Метод чтения количества чисел для ввода
int[,] ReadLengthArr()
{
    int[,] sizeArr = new int[2, 2];
    Console.Write("Введите колличество строк: ");
    sizeArr[0, 0] = int.Parse(Console.ReadLine());
    Console.Write("Введите колличество столбцов: ");
    sizeArr[0, 1] = int.Parse(Console.ReadLine());
    //Для вариативного заполнения массива
    //Console.Write("Введите число начала диапазона чисел: ");
    //arrSize[1, 0] = int.Parse(Console.ReadLine());
    //Console.Write("Введите число конца диапазона чисел: ");
    //arrSize[1, 1] = int.Parse(Console.ReadLine());

    return sizeArr;
}

//Метод заполнения двумерного массива 
int[,] FillArray(int[,] sizeArr)
{
    int countRow = sizeArr[0, 0];
    int countCalumn = sizeArr[0, 1];
    System.Random numberSintezator = new System.Random();
    int[,] outArray = new int[countRow, countCalumn];
    for (int i = 0; i < countRow; i++)
    {
        int j = 0;
        for (j = 0; j < countCalumn; j++)
        {
            outArray[i, j] = numberSintezator.Next(0, 100);

        }
    }
    return outArray;
}

///Метод для вывода двумерного массива
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

// Метод нахождения суммы элементов строки и добавления его в одномерный массив
int[] SumInRow(int[,] array)
{
    int[] outArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 0;
        int sum = 0;
        for (j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            outArray[i] = sum;
        }
    }
    return outArray;
}


// Метод поиска минимального элемента суммы в одномерном массиве 
int[] MinElemArray(int[] array)
{
    int[] result = new int[2];
    int min = array[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            result[0] = array[i];
            result[1] = i;
        }

    }
    return result;
}

int[,] genArray = FillArray(ReadLengthArr());
PrintTwoDimArray(genArray);

Console.WriteLine($"Минимальная сумма элементов в массиве равна {MinElemArray(SumInRow(genArray))[0]} в {MinElemArray(SumInRow(genArray))[1]} строке.");





