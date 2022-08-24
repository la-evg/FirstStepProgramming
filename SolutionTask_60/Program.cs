/*=======================================================================
// Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу,  
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
========================================================================*/

Console.Clear();

//Метод чтения параметров для заполенения массива
int[] ReadThreeDimLengthArr()
{
    int[] sizeArr = new int[3];
    Console.Write("Введите колличество строк: ");
    sizeArr[0] = int.Parse(Console.ReadLine());
    Console.Write("Введите колличество столбцов: ");
    sizeArr[1] = int.Parse(Console.ReadLine());
    Console.Write("Введите колличество строк в глубину: ");
    sizeArr[2] = int.Parse(Console.ReadLine());

    return sizeArr;
}


//Метод для заполнения трёхмерного массива
int[,,] FillThreeDimArray(int[] sizeArray)
{
    int countRow =  sizeArray[0];
    int countColumn = sizeArray[1];
    int countDepth = sizeArray[2];
    System.Random numberSyntezator = new System.Random();

    int i = 0; int j = 0; int k = 0; int num = 0;
    //Создаем список
    List<int> numbers = new List<int>();
    //Создаем массив
    int[,,] outArray = new int[countRow, countColumn, countDepth];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            k = 0;
            while (k < countDepth)
            {
                num = numberSyntezator.Next(10, 100);
                if (numbers.Contains(num))
                { }
                else
                {
                    outArray[i, j, k] = num;
                }
                k++;
            }
            j++;
        }
        i++;
    }

    //Возвращаем значение
    return outArray;
}

//Метод  печати трехмерного массива
void PrintThreeDimArray(int[,,] inputArray)
{
    int i = 0; int j = 0; int k = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            k = 0;
            while (k < inputArray.GetLength(2))

            {
                Console.Write($"{inputArray[i, j, k]}({i},{j},{k})" + "\t");
                k++;
            }
            j++;
        }
        Console.Write("\n");
        i++;
    }
}


int[,,] genArray = FillThreeDimArray(ReadThreeDimLengthArr());
Console.Write("\n");
PrintThreeDimArray(genArray);





