// Решение от Ирины 

Console.WriteLine("Является ли первое число квадратом второго?");
Console.Write("Введите первое число: ");
string? inputLinkOne = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputLinkTwo = Console.ReadLine();


if (inputLinkOne != null && inputLinkTwo != null)
{
    int first = int.Parse(inputLinkOne);
    int second = int.Parse(inputLinkTwo);
    int c = second % first;
    string iext = "";
    Console.WriteLine(iext);
    if (c == 0)
    {
        iext = "Да. Второе число кратно первому.";
        Console.WriteLine(iext);
    } else {
        iext = "Нет. Второе число не кратно первому. Остаток от деления: " + c;
        Console.WriteLine(iext);
    }    
}
// Решение от Артёма
/*
Console.WriteLine("Является ли первое число квадратом второго?");
Console.Write("Введите первое число: ");
string? inputLinkOne = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputLinkTwo = Console.ReadLine();
int first = int.Parse(inputLinkOne);
int second = int.Parse(inputLinkTwo);
if (second%first == 0)
{
    Console.WriteLine("Кратное");
} else {
    Console.WriteLine("Не кратное. " + "Остаток от деления: " + second%first);
}
*/


/*
// Решение от Николая
Console.WriteLine("Является ли первое число квадратом второго?");
Console.Write("Введите первое число: ");
string? inputLinkOne = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputLinkTwo = Console.ReadLine();
if (inputLinkOne!= null && inputLinkTwo != null)
{
    int inputNumberOne = int.Parse(inputLinkOne);
    int inputNumberTwo = int.Parse(inputLinkTwo);
    int div = inputNumberTwo % inputNumberOne;
    if (div == 0){
        Console.WriteLine("Да");
    } else {
        Console.WriteLine("Нет");
    }
}
*/