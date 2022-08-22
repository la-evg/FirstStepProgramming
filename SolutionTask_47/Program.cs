/* 
 №47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
* При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
*/

Console.Clear();

//Метод чтения количества чисел для ввода
int[,] ReadLengthArr()
{
    int[,] arrSize = new int[2, 2];
    Console.Write("Введите колличество строк: ");
    arrSize[0, 0] = int.Parse(Console.ReadLine());
    Console.Write("Введите колличество столбцов: ");
    arrSize[0, 1] = int.Parse(Console.ReadLine());
    //Console.Write("Введите число начала диапазона чисел: ");
    //arrSize[1, 0] = int.Parse(Console.ReadLine());
    //Console.Write("Введите число конца диапазона чисел: ");
    //arrSize[1, 1] = int.Parse(Console.ReadLine());

    return arrSize;
}

// Метод генерации двумерного массива из входных параметров
double[,] GenerateArray(int[,] size)
{
    System.Random numberSintezator = new System.Random();
    double[,] genArr = new double[size[0, 0], size[0, 1]];
    for (int i = 0; i < size[0, 0]; i++)
    {
        for (int j = 0; j < size[0, 1]; j++)
        {
            genArr[i, j] = Math.Round(numberSintezator.NextDouble(), 2) + numberSintezator.Next(0, 10);
        }
    }
    return genArr;
}

//Метод для вывода двумерного массива
void PrintTwoDimArray(double[,] inputArray)
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

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

//Метод для цветного вывода двумерного массива
void PrintColorTwoDimArray(double[,] inputArray)
{
    int i = 0; int j = 0;
    int buffColor = 0;
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        Console.Write("[");
        while (j < inputArray.GetLength(1) - 1)
        {

            Console.ForegroundColor = col[buffColor];
            Console.Write(Math.Round(inputArray[i, j], 2));
            Console.ResetColor();
            Console.Write(", \t");
            buffColor++;
            j++;
        }
        Console.ForegroundColor = col[buffColor];
        Console.Write(Math.Round(inputArray[i, j], 2));
        Console.ResetColor();
        Console.Write("]\n");
        buffColor++;
        i++;
    }


}


double[,] array = GenerateArray(ReadLengthArr());
//PrintTwoDimArray(array);
PrintColorTwoDimArray(array);