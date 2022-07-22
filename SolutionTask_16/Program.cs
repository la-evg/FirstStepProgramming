// //Решение Николая

// string? inputLkneOne = Console.ReadLine();
// string? inputLkneTwo = Console.ReadLine();
// if(inputLkneOne != null && inputLkneTwo != null ){
//     int inputNumberOne = Math.Abs(int.Parse(inputLkneOne));
//     int inputNumberTwo = Math.Abs(int.Parse(inputLkneTwo));
//     double sq = 0;

//     if(inputNumberOne > inputNumberTwo){
//         sq = Math.Sqrt(inputNumberOne);
//     }else{
//         sq = Math.Sqrt(inputNumberTwo);
//     }

//     if(sq == inputNumberOne ^ sq == inputNumberTwo){
//         Console.WriteLine("Да");
//     }else{
//         Console.WriteLine("Нет");
//     }
    
// }


// //Решение Кирилла

// Console.WriteLine("Введите два числа:");

// string? inputOne = Console.ReadLine();
// string? inputTwo = Console.ReadLine();

// if (inputOne != null && inputTwo != null)
// {
//     int numOne = int.Parse(inputOne);   
//     int numTwo = int.Parse(inputTwo);  

//     if (Math.Sqrt(numOne) == numTwo) 
//     {
//         Console.WriteLine("Yes");
//     } 
//     else if (Math.Sqrt(numTwo) == numOne) 
//     {
//         Console.WriteLine("Yes");   
//     }
//     else
//     {
//         Console.WriteLine("No");
//     }
// }

//Решение Никиты

// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

Console.Clear();

Console.WriteLine("Введите первое число:");
string? inputFirst = Console.ReadLine();
Console.WriteLine("Введите второе число:");
string? inputSecond = Console.ReadLine();

if ((inputFirst != null) && (inputSecond != null))
{
    int inputNumberFirst = int.Parse(inputFirst);
    int inputNumberSecond = int.Parse(inputSecond);
    int a = inputNumberFirst * inputNumberFirst;
    int b = inputNumberSecond * inputNumberSecond;
    if ((a == inputNumberSecond) || (b == inputNumberFirst))
    {
        Console.WriteLine("Да!");
    }
    else
    {
        Console.WriteLine("Нет!");
    }

}