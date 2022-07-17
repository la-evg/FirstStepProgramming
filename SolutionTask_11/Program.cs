// Решение от Артёма
// Вариант 1
void searchNum()
{
    int number = new Random().Next(100, 1000);
    Console.WriteLine("Число: " + number);
    int numberSecondDigit = number / 100;
    int numberThirdDigit = number % 10;
    Console.WriteLine("После удаления второй цифры: " + numberSecondDigit + numberThirdDigit);
}

// Решения от Кирилла:
// Вариант 1
void middleDigitCutter()
{
    int number = new Random().Next(100, 1000);
    Console.Write("The random number is: ");
    Console.WriteLine(number);
    string stringNumber = number.ToString();
    Console.Write("Without the middle digit is: ");
    Console.Write(stringNumber[0]);
    Console.WriteLine(stringNumber[2]);
}

// Вариант 2
void middleDigitCutter2()
{
    int number = new Random().Next(100, 1000);
    Console.Write("The random number is: ");
    Console.WriteLine(number);
    int num1 = number / 100;
    int num2 = number % 10;
    Console.Write("Modifed number is: ");
    Console.Write(num1 * 10 + num2);
}

Console.WriteLine("-----Вариант 1 Артема -----");
searchNum();
Console.WriteLine("-----Вариант 1 Кирилла -----");
middleDigitCutter();
Console.WriteLine("-----Вариант 2 Кирилла -----");
middleDigitCutter2();