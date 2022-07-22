//Метод считывает точкии возвращает массив с ними
int[,] readPoint()
{
    string inputLine=Console.ReadLine();

    string coordXLine=inputLine.Substring(0,inputLine.IndexOf(";"));
    coordXLine=coordXLine.Substring(inputLine.IndexOf("=")+1);

    string coordYLine=inputLine.Substring(0,inputLine.IndexOf(";")+1);
    coordYLine=coordYLine.Substring(inputLine.IndexOf("=")+1);

    Console.WriteLine(coordXLine+" "+coordYLine);

    int coordX=int.Parse(coordXLine);
    int coordY=int.Parse(coordYLine);

    int[,] arrayOut=new int[1,2];
    arrayOut[0,0]=coordX;
    arrayOut[0,1]=coordY;

    return arrayOut;
    

}

//Печатает номер четверти
void printQuter(int[,] arreyPoint)
{
    if (arreyPoint[0,0]>0&&arreyPoint[0,1]>0)
    Console.WriteLine("1 четверть");

    if (arreyPoint[0,0]<0&&arreyPoint[0,1]>0)
    Console.WriteLine("2 четверть");

    if (arreyPoint[0,0]<0&&arreyPoint[0,1]<0)
    Console.WriteLine("3 четверть");

    if (arreyPoint[0,0]<0&&arreyPoint[0,1]>0)
    Console.WriteLine("4 четверть");

}

int[,] arreyPoint= readPoint();

printQuter(arreyPoint);

//printQuter(readPoint());