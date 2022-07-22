// Объявление глобальных переменных
int coordXPointA;
int coordYPointA;
int coordZPointA;
int coordXPointB;
int coordYPointB;
int coordZPointB;

double lengthAB;

//Метод читывания координат точек
void readDataOfPoint()
{
    Console.Clear();
    //Считывание координат для точки А
    Console.WriteLine("Введите координату X точки А");
    coordXPointA=int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки А");
    coordYPointA=int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки А");
    coordZPointA=int.Parse(Console.ReadLine());

    Console.WriteLine("-----------------");

    //Считывание координат для точки B
    Console.WriteLine("Введите координату X точки B");
    coordXPointB=int.Parse(Console.ReadLine());
  
    Console.WriteLine("Введите координату Y точки B");
    coordYPointB=int.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите координату Z точки B");
    coordZPointB=int.Parse(Console.ReadLine());
    
}



//Метод вычисления расстояние между А и В
void lenghtPoints()
{
    lengthAB=Math.Sqrt(Math.Pow((coordXPointA-coordXPointB),2)+Math.Pow((coordYPointA-coordYPointB),2)+Math.Pow((coordZPointA-coordZPointB),2));
}

readDataOfPoint();
lenghtPoints();

Console.WriteLine(lengthAB);