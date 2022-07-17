String? InputNum = Console.ReadLine();

if(InputNum != null)
{
    int StartNum = 2;
    string LineOutput = "";

    while(StartNum <= (int.Parse(InputNum))){
        if(StartNum % 2 == 0){
            LineOutput = LineOutput + StartNum + ", ";
        }
        StartNum+=2;
    }
    Console.WriteLine(LineOutput.Remove(LineOutput.Length - 2));
}
