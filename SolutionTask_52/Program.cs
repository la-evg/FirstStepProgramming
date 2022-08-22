/* 
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
столбце.
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

//Вычисление среднего арифметического в каждом столбце массива
void Average(int[,] inputArr)
{
    double sum = 0;
    for (int j = 0; j < inputArr.GetLength(1); j++)
    {
        for (int i = 0; i < inputArr.GetLength(0); i++)
        {
            sum += inputArr[i, j];
        }
        Console.Write(Math.Round(sum / inputArr.GetLength(1), 1) + "; ");
    }
}

int[,] genArray = GenerateArray(ReadLengthArr());
PrintTwoDimArray(genArray);
Average(genArray);