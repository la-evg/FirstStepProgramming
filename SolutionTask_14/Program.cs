Console.Write("Введите число: ");

//Решение Николая
string? inputLkneOne = Console.ReadLine();
if(inputLkneOne != null){
    int inputNumberOne = int.Parse(inputLkneOne);
    if(inputNumberOne%7 == 0 && inputNumberOne%23 == 0){
        Console.WriteLine("Да");
    }else{
        Console.WriteLine("Нет");
    }
}

//Решение Артема

Console.Write("Enter number: ");
string? firstLine = Console.ReadLine();
int first = int.Parse(firstLine);


if (first%7 == 0 && first%23 == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine("Не кратное");
}

//Решение Кирилла

string reminderSearcher(string str)
{
    if (str != null)
    {
        try
        {
            string answer;
            int num = int.Parse(str);
            if (((num % 7) == 0) && ((num % 23) == 0))
            {
                answer = "It's multiple for 7 and 23";
            }
            else
            {
                answer = "It's not multiple for 7 and 23";
            }
            return answer;
        }
        catch (Exception e)
        {
            return "Возникло исключение: " + e.Message;
        }
    }
    return "";
}

Console.WriteLine("Input number: ");

string? inputOne = Console.ReadLine();

Console.WriteLine(reminderSearcher(inputOne));