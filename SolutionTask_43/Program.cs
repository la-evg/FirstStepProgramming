/* 
Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

 */

 //Метод запроса для ввода координат точек. Данные записываются в двумерный массив
double[,] ReadCoordinates()
{
    double[,] coordArray = new double[2, 2];

    Console.Write("Введите число K1: ");
    coordArray[0, 0] = double.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число B1: ");
    coordArray[0, 1] = double.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число K2: ");
    coordArray[1, 0] = double.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите число B2: ");
    coordArray[1, 1] = double.Parse(Console.ReadLine() ?? "");

    Console.WriteLine($"Получили отрезки с координатами {coordArray[0, 0]};{coordArray[0, 1]} и {coordArray[1, 0]};{coordArray[1, 1]}");

    return coordArray;
}

//Метод вычисления точки пересечения линий. Расчет производится по формулам x = (b2 - b1) / (k1 - k2); y = (k1 * x) + b1;
double[] CalculateTask(double[,] inputArray)
{
    double[] coordLineCross = new double[2];

    coordLineCross[0] = (inputArray[1,1] - inputArray[0,1]) / (inputArray[0,0] - inputArray[1,0]);
    coordLineCross[1] = inputArray[0, 0] * coordLineCross[0] + inputArray[0, 1];

    return coordLineCross;
}

//Метод вывода координат точек пересечения
void PrintAnswer(double[] inputArray)
{
    Console.Write($"Точка пересечения двух прямых: {inputArray[0]};{inputArray[1]}");
}

//Вызов функций
PrintAnswer(CalculateTask(ReadCoordinates()));