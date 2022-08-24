/*=======================================================================
Задайте двумерный массив. Напишите программу, 
которая упорядочит по возрастанию элементы каждой строки двумерного массива.
========================================================================*/
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



// метод заполнения двумерного массива 
int[,] FillArray(int[,] sizeArr)
{
    int countRow = sizeArr[0, 0];
    int countCalumn = sizeArr[0, 1];
    int[,] outArray = new int[countRow, countCalumn];
    System.Random numberSintezator = new System.Random();
    for (int i = 0; i < countRow; i++)
    {
        int j = 0;
        for (j = 0; j < countCalumn; j++)
        {
            outArray[i, j] = numberSintezator.Next(0, 100);
            //Для вариативного заполнения массива
            //outArray[i, j] = numberSintezator.Next(arrSize[1, 0], arrSize[1, 1]);
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


// Метод сортировки элементов в строке по возростанию  
int[,] RiseRow(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int j = 1;
        for (j = 1; j < array.GetLength(1); j++)
        {
            int k = 0;
            int temp = 0;
            for (k = j; k > 0; k--)
            {
                if (array[i, k] < array[i, k - 1])
                {
                    temp = array[i, k - 1];
                    array[i, k - 1] = array[i, k];
                    array[i, k] = temp;
                }
                else
                    break;
            }
        }
    }
    return array;
}


int[,] genArray = FillArray(ReadLengthArr());
PrintTwoDimArray(genArray);
Console.WriteLine("----------------------");
PrintTwoDimArray(RiseRow(genArray));
Console.WriteLine();
