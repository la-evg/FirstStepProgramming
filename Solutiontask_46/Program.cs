//=========================================================================================================
// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// Разбор на семинаре
//=========================================================================================================

// метод для заполнения двумерного массива
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;
    }
    return outArray;
}

//метод для печати двумерного массива
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

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

void PrintColorTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        Console.ForegroundColor = col[new System.Random().Next(0, 16)];
        Console.Write("[");
        while (j < inputArray.GetLength(1) - 1)
        {
            Console.Write(inputArray[i, j] + ", ");
            j++;
        }
        Console.Write(inputArray[i, j]);
        Console.Write("]");
        //Console.Write("\n");
        Console.WriteLine();
        i++;
    }
    Console.ResetColor(); 

}

int[,] twoDimArray = FillTwoDimArray(5, 8);
PrintTwoDimArray(twoDimArray);
Console.WriteLine();
PrintColorTwoDimArray(twoDimArray);
