//====================================
// Заполните спирально массив 4 на 4.
//====================================
// Вариант от Ирины
//====================================

Console.Clear();
//Метод чтения количества чисел для ввода
int[] ReadLengthArr()
{
    int[] sizeArr = new int[2];
    Console.Write("Введите колличество строк: ");
    sizeArr[0] = int.Parse(Console.ReadLine());
    Console.Write("Введите колличество столбцов: ");
    sizeArr[1] = int.Parse(Console.ReadLine());

    return sizeArr;
}

//Генератор спиральной матрицы
int[,] GenSpiralArray(int[] size)
{
    int i = 0;
    int n = size[0];
    int m = size[1];
    int[,] newArrey = new int[n, m];
    int row = 0;
    int col = 0;
    int a = 1;
    int b = 0;
    int shift = 0;
    int reserve = m;
    int temp = a;
    while (i++ < n * m)
    {
        newArrey[row, col] = i;
        if (--reserve == 0)
        {
            reserve = m * (shift % 2) + n * ((shift + 1) % 2) - (shift / 2 - 1) - 2;
            temp = a;
            a = -b;
            b = temp;
            shift++;
        }
        col += a;
        row += b;
    }
    return newArrey;
}

//Выводим на печать массив
void PrintTwoDimensionalArray(int[,] arr)
{
    int val;
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            val = arr[i, j];
            Console.Write(new string(' ', arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1].ToString().Length + 2 - val.ToString().Length));
            Console.Write(val);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

PrintTwoDimensionalArray(GenSpiralArray(ReadLengthArr()));