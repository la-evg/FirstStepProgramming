Console.Clear();

// зарание объявляются глобальнфе переменные!
int coordXPointA;
int coordYPointA;
int coordXPointB;
int coordYPointB;
double lengthAB;

// считывает координаты точек A и B
void readCoordOfPoints()
{
    Console.Write("Введите координаты Х в точке А: ");
    coordXPointA = int.Parse(Console.ReadLine());

    Console.Write("Введите координаты Y в точке А: ");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.Write("Введите координаты X в точке B: ");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.Write("Введите координаты Y в точке B: ");
    coordYPointB = int.Parse(Console.ReadLine());
}

// вычисляет расстояние между точками A и B
void calculateLengthAB()
{
lengthAB = Math.Sqrt(Math.Pow(coordXPointA - coordXPointB, 2) + Math.Pow(coordYPointA - coordYPointB, 2));
} 

readCoordOfPoints();
calculateLengthAB();

Console.Write(lengthAB);