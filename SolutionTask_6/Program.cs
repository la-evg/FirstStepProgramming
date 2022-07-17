string? InputFirstNumber = Console.ReadLine();
string? InputSecondNumber = Console.ReadLine();
string? InputThirdNumber = Console.ReadLine();

if(InputFirstNumber != null && InputSecondNumber != null && InputThirdNumber != null)
{
    int FirstNumber = int.Parse(InputFirstNumber);
    int SecondNumber = int.Parse(InputSecondNumber);
    int ThirdNumber = int.Parse(InputThirdNumber);

    if(FirstNumber > SecondNumber){
        if(FirstNumber > ThirdNumber){
            Console.WriteLine(FirstNumber);
        }
        else{
            Console.WriteLine(ThirdNumber);
        }
    }
    else{
        if(SecondNumber > ThirdNumber){
            Console.WriteLine(SecondNumber);
        }
        else{
            Console.WriteLine(ThirdNumber);
        }
    }
}