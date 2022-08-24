/*=======================================================================
Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
========================================================================*/


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
            outArray[i, j] = numberSintezator.Next(10, 100);

        }
    }
    return outArray;
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

//Метод проверки размерностей массивов
bool CheckSize(int[,] firstArray, int[,] secondArray)
{
    if (firstArray.GetLength(0) == secondArray.GetLength(0) && firstArray.GetLength(1) == secondArray.GetLength(1))
    {
        return true;
    }
    else
        return false;
}

// Метод прямого перемножения массивов 
int[,] MultiplyArray(int[,] firstArray, int[,] secondArray)
{
    int[,] outArray = new int[firstArray.GetLength(0), firstArray.GetLength(1)];
    for (int i = 0; i < outArray.GetLength(0); i++)
    {
        int j = 0;
        for (j = 0; j < outArray.GetLength(1); j++)
        {
            outArray[i, j] = firstArray[i, j] * secondArray[i, j];
        }
    }

    return outArray;
}

Console.WriteLine("-----Первый массив-----");
int[,] genFirstArray = FillArray(ReadLengthArr());
PrintTwoDimArray(genFirstArray);
Console.WriteLine();

Console.WriteLine("-----Второй массив-----");
int[,] genSecondArray = FillArray(ReadLengthArr());
PrintTwoDimArray(genSecondArray);
Console.WriteLine();

if (CheckSize(genFirstArray, genSecondArray))
{
    Console.WriteLine("-----Перемноженный массив-----");
    PrintTwoDimArray(MultiplyArray(genFirstArray, genSecondArray));
}
else
{
    Console.WriteLine("Невозможно перемножить массивы разных размеров.");
}




