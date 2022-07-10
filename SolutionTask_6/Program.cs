string? InputFirstNumber = Console.ReadLine();
string? InputSecondNumber = Console.ReadLine();
string? InputThirdNumber = Console.ReadLine();

if(InputFirstNumber != null && InputSecondNumber != null && InputThirdNumber != null)
{
    if(int.Parse(InputFirstNumber) > int.Parse(InputSecondNumber)){
        if(int.Parse(InputFirstNumber) > int.Parse(InputThirdNumber)){
            Console.WriteLine(InputFirstNumber);
        }
        else{
            Console.WriteLine(InputThirdNumber);
        }
    }
    else{
        if(int.Parse(InputSecondNumber) > int.Parse(InputThirdNumber)){
            Console.WriteLine(InputSecondNumber);
        }
        else{
            Console.WriteLine(InputThirdNumber);
        }
    }
}