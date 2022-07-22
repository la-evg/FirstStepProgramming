//Является ли 5значное число палиндромом.

Console.Write("Введите пятизначное число: ");
string? inputLine = Console.ReadLine();
;

void checkNumber(int number)
{
    //Разбиваем число на отдельные цифры
    int digit1 = number / 10000;
    int digit2 = (number / 1000) % 10;
    int digit3 = (number / 100) % 10;
    int digit4 = (number / 10) % 10;
    int digit5 = number % 10;

    //Сравниваем 1 и 5 число и 2 и 4 число и выводим ответ
    if ((digit1 == digit5) && (digit2 == digit4))
    {
        Console.WriteLine("Да, число палиндром");
    }
    else Console.WriteLine("Нет, число не палиндром");
}
//Выполняем проверку на пустую строку
if (inputLine != null)
{
    //Переводим строку в целочисленное
    int inputNumber = int.Parse(inputLine);
    checkNumber(inputNumber);
}


