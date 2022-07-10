String? InputNum = Console.ReadLine();

if(InputNum != null)
{
    int StartNum = 1;
    string LineOutput = "";

    while(StartNum <= (int.Parse(InputNum))){
        if(StartNum % 2 == 0){
            LineOutput = LineOutput + StartNum + ", ";
        }
        StartNum++;
    }
    Console.WriteLine(LineOutput.Remove(LineOutput.Length - 2));
}
